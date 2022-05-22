using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuayaquilManager : MonoBehaviour
{
    [SerializeField] private CameraController camera_controller;

    [Header("Protas Objects")]
    [SerializeField] private Transform prota_parent_transform;
    [SerializeField] private Vector3 local_position;
    [SerializeField] private Vector3 local_scale;
    private GameObject prota_selected;

    [Header("Event Objects")]
    [SerializeField] private Object event_objects;

    private GameManager game_manager;

    public static GuayaquilManager guayaquil_manager;
    
    private void Awake()
    {
        game_manager = GameManager.instance;
    }

    void Start()
    {
        prota_selected = game_manager.Spawn_Character("prota",
                                                      prota_parent_transform,
                                                      local_position,
                                                      local_scale);
        camera_controller.player_target = prota_selected.transform;
    }

}
