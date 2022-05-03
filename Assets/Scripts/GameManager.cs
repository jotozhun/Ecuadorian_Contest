using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int character_selected;


    public static GameManager instance;

    private void Awake()
    {
        if (instance != null && instance != this)
            Destroy(this.gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
    }


    void Update()
    {
        
    }


    
    public void ChangeScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

}
