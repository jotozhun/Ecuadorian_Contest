using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class NPCMovement : MonoBehaviour
{
    public AIPath aIPath;
    public Animator animator;
    Vector2 direction; 

    private Vector2 last_position;
    private Vector2 current_position;
    private Vector2 calculated_velocity;

    private float time_between_calculate;


    [SerializeField]
    private SpriteRenderer sprite_renderer;
    private void Start()
    {
        last_position = current_position = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        ChangeAnimaterParameters();
        CalculateVelocity();
    }

    void ChangeAnimaterParameters()
    {
        direction = aIPath.desiredVelocity;
        if (!Mathf.Approximately(direction.x, 0.0f) || !Mathf.Approximately(direction.y, 0.0f))
        {
            animator.SetFloat("Look X", direction.x);
            animator.SetFloat("Look Y", direction.y);
         }
        //animator.SetFloat("Speed", aIPath.speed);
    }

    void CalculateVelocity()
    {
        time_between_calculate += Time.deltaTime;
        if (time_between_calculate > 0.2f){ 
            current_position = this.transform.position;
            calculated_velocity = current_position - last_position;
            Debug.Log("Current velocity: " + calculated_velocity);
            animator.SetFloat("Speed", calculated_velocity.magnitude);
            last_position = current_position;
            time_between_calculate = 0.0f;
        }
    }
}
