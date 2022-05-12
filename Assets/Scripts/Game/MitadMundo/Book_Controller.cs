using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book_Controller : MonoBehaviour
{
    Mitad_Mundo_Manager mitad_mundo_manager;

    private bool hasPlayerEntered;

    private void Start()
    {
        mitad_mundo_manager = Mitad_Mundo_Manager.instance;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            hasPlayerEntered = true;
            mitad_mundo_manager.OnPlayerEntersBook();
        }
    }

    private void Update()
    {
        if(hasPlayerEntered && Input.GetKeyDown(KeyCode.E))
        {
            mitad_mundo_manager.OnPlayerOpensBook();
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            mitad_mundo_manager.OnPlayerLeavesBook();
            hasPlayerEntered = false;
        }
    }
}
