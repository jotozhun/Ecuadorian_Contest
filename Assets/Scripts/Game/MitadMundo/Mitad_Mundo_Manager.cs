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
    private Vector3 local_position = new Vector3(-40, -10, 0);
    private Vector3 local_scale = new Vector3(2, 2, 2);

    [Header("Prota UI Objects")]
    public GameObject[] protas_book_animation;
    public GameObject prota_book_animation_selected;

    public Transform prota_parent_transform;

    GameManager game_manager;

    public static Mitad_Mundo_Manager instance;
    
    private void Awake()
    {
        game_manager = GameManager.instance;
        instance = this;
    }

    void Start()
    {
        prota_selected = game_manager.Spawn_Character("prota", 
                                                       prota_parent_transform,
                                                       local_position,
                                                       local_scale);
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
