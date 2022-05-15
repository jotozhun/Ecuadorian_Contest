using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ChooseCinematicAtahualpa : MonoBehaviour
{
    public VideoPlayer video_player;
    public VideoClip[] protas_videos;

    public int selected_index;
    private void Awake()
    {
        selected_index = GameManager.instance.character_selected;
        
    }

    void Start()
    {
        video_player.clip = protas_videos[selected_index];
        video_player.loopPointReached += LoadGuayaquil;
    }

    void LoadGuayaquil(VideoPlayer player)
    {
        GameManager.instance.ChangeScene("Guayaquil");
    }
}
