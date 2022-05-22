using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Intro_Handler : MonoBehaviour
{
    [SerializeField]
    private VideoPlayer video_player;

    private void Start()
    {
        video_player.loopPointReached += LoadMitadMundo;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        { 
            GameManager.instance.SkipVideo(video_player);
        }
    }

    void LoadMitadMundo(VideoPlayer vp)
    {
        GameManager.instance.ChangeScene("MitadMundo");
    }
}
