using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    [SerializeField]
    private CharacterController character_controller;

    [SerializeField]
    private float speed_x;

    [SerializeField]
    private float speed_y;

    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        float vel_x = Input.GetAxis(ConstantUtilities.HORIZONTAL_MOVEMENT) * speed_x * Time.deltaTime;
        float vel_y = Input.GetAxis(ConstantUtilities.VERTICAL_MOVEMENT) * speed_y * Time.deltaTime;

        character_controller.Move(new Vector3(vel_x, vel_y, 0f));
    }
}
