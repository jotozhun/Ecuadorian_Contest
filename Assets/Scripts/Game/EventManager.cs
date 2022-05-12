using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventManager : MonoBehaviour
{
    public static event Action AtahualpaTalk;

    public static void ReproduceAtahualpaTalk()
    {
        AtahualpaTalk?.Invoke();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
