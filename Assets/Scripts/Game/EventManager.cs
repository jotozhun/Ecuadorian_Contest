using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventManager : MonoBehaviour
{
    GameManager game_manager;
    public static event Action AtahualpaTalk;
    // Start is called before the first frame update

    private void Awake()
    {
        game_manager = GameManager.instance;
    }

    public static void ReproduceAtahualpaTalk()
    {
        AtahualpaTalk?.Invoke();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
