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
    void Update()
    {
        PlayerMovement();
        Animate();
    }

    void PlayerMovement()
    {
        movement.x = Input.GetAxis(ConstantUtilities.HORIZONTAL_MOVEMENT);
        movement.y = Input.GetAxis(ConstantUtilities.VERTICAL_MOVEMENT);
    }

    private void FixedUpdate()
    {
        character_rigidbody.MovePosition(character_rigidbody.position + movement * speed * Time.fixedDeltaTime);
    }

    void Animate()
    {
        character_animator.SetFloat("Look X", movement.x);
        character_animator.SetFloat("Look Y", movement.y);
    }
}
