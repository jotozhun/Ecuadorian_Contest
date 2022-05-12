using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mitad_Mundo_Manager : MonoBehaviour
{
    [SerializeField]
    private CameraController camera_controler;

    [SerializeField]
    private GameObject book_msj_object;

    [Header("Protas Objects")]
    public GameObject[] protas;
    public GameObject prota_selected;

    [Header("Prota UI Objects")]
    public GameObject[] protas_book_animation;
    public GameObject prota_book_animation_selected;

    public Transform prota_parent_transformn;

    GameManager game_manager;

    public static Mitad_Mundo_Manager instance;
    private Vector3 local_position = new Vector3(-40, -10, 0);
    private void Awake()
    {
        game_manager = GameManager.instance;
        instance = this;
    }

    void Start()
    {
        // Prota instantiate and place in the scene
        prota_selected = Instantiate(protas[game_manager.character_selected], prota_parent_transformn);
        prota_selected.transform.localPosition = local_position;
        camera_controler.player_target = prota_selected.transform;

        // Other configs
        prota_book_animation_selected = protas_book_animation[game_manager.character_selected];
    }

    public void OnPlayerEntersBook()
    {
        book_msj_object.SetActive(true);
    }

    public void OnPlayerLeavesBook()
    {
        book_msj_object.SetActive(false);
    }

    public void OnPlayerOpensBook()
    {
        OnPlayerLeavesBook();
        prota_selected.SetActive(false);
        camera_controler.player_target = prota_book_animation_selected.transform;
        prota_book_animation_selected.SetActive(true);
    }
}
