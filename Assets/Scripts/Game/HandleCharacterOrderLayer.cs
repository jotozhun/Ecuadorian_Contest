using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleCharacterOrderLayer : MonoBehaviour
{
    public SpriteRenderer character_sprite_render;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle") && collision.isTrigger)
        {
            character_sprite_render.sortingOrder = 2;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle") && collision.isTrigger)
        {
            character_sprite_render.sortingOrder = 7;
        }
    }
}
