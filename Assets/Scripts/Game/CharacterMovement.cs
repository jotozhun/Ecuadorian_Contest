using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField]
    private Animator character_animator;

    [SerializeField]
    private Rigidbody2D character_rigidbody;

    [SerializeField]
    private float speed_x;

    [SerializeField]
    private float speed_y;

    [SerializeField]
    private Vector2 speed;


    private Vector2 movement;

    Vector2 look_direction = new Vector2(1, 0);
    void Update()
    {
        PlayerMovement();
        Animate();
    }

    void PlayerMovement()
    {
        if(!Mathf.Approximately(movement.x, 0.0f) || !Mathf.Approximately(movement.y, 0.0f))
        {
            character_animator.SetFloat("Look X", movement.x);
            character_animator.SetFloat("Look Y", movement.y);
        }
        movement.x = Input.GetAxis(ConstantUtilities.HORIZONTAL_MOVEMENT) * speed.x;
        movement.y = Input.GetAxis(ConstantUtilities.VERTICAL_MOVEMENT) * speed.y;
    }

    private void FixedUpdate()
    {
        character_rigidbody.MovePosition(character_rigidbody.position + movement * Time.fixedDeltaTime);
    }

    void Animate()
    {
        character_animator.SetFloat("Speed", movement.magnitude);
    }

}
