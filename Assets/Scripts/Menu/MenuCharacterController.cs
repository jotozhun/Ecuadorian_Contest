using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MenuCharacterController : MonoBehaviour
{
    [SerializeField]
    private CanvasRenderer character_renderer;

    public bool selected;

    [Header("Menu Character properties")]
    [SerializeField]
    public int character_id;

    private void Start()
    {
        //character_renderer = GetComponent<CanvasRenderer>();
    }

    public void SelectCharacter()
    {
        character_renderer.SetColor(Color.green);
    }


    public void DeselectCharacter()
    {
        character_renderer.SetColor(Color.white);
    }
}
