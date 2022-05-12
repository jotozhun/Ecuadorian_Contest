using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Events : MonoBehaviour
{
    public void ChangeScene(string name)
    {
        GameManager.instance.ChangeScene(name);
    }
}
