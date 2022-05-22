using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class GameManager : MonoBehaviour
{
    [Header("Character Objects")]
    [SerializeField] private GameObject[] protas_objs;
    [SerializeField] private GameObject dama_tapada_obj;
    [SerializeField] private GameObject kid_obj;
    [SerializeField] private GameObject atahualpa_obj;

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

    public GameObject Spawn_Character(string character,
                                      Transform parent_transform,
                                      Vector3 local_position,
                                      Vector3 local_scale)
    {
        GameObject character_instantiated = null;
        switch(character)
        {
            case "prota":
                character_instantiated = Instantiate(protas_objs[character_selected], parent_transform);
                break;
            case "dama_tapada":
                character_instantiated = Instantiate(dama_tapada_obj, parent_transform);
                break;
            case "kid":
                character_instantiated = Instantiate(kid_obj, parent_transform);
                break;
            case "atahualpa":
                character_instantiated = Instantiate(atahualpa_obj, parent_transform);
                break;
        }
        character_instantiated.transform.localPosition = local_position;
        character_instantiated.transform.localScale = local_scale;
        return character_instantiated;
    }

    public void SkipVideo(VideoPlayer vp)
    {
        vp.time = vp.length;
    }
    
    public void ChangeScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

}
