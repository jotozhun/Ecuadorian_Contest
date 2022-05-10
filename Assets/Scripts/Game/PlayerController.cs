using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Book"))
        {
            EventManager.AtahualpaTalk += ReproduceAtahualpaIntro;
        }
    }

    private void ReproduceAtahualpaIntro()
    {

    }

}
