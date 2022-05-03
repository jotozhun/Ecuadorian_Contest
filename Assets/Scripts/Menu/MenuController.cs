using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MenuController : MonoBehaviour
{
    // Main Screen Buttons
    [SerializeField]
    private Button play_btn;
    [SerializeField]
    private Button select_character_btn;
    [SerializeField]
    private Button exit_btn;
    [SerializeField]
    private GameObject main_screen;
    [SerializeField]
    private GameObject select_character_screen;
    [SerializeField]
    private Button sadsad;
    [SerializeField]
    private MenuCharacterController male_character_controller;
    [SerializeField]
    private MenuCharacterController female_character_controller;


    private GameManager game_manager;
    // Start is called before the first frame update
    void Start()
    {
        game_manager = GameManager.instance;
        SelectMainCharacter(male_character_controller);
        male_character_controller.SelectCharacter();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //General
    public void ChangeScreen(GameObject screen)
    {
        main_screen.SetActive(false);
        select_character_screen.SetActive(false);
        screen.SetActive(true);
        if (screen == select_character_screen)
        {
            SelectCharacterMenu();
        }
    }


    private void SelectCharacterMenu()
    {
        if (game_manager.character_selected == 0)
            male_character_controller.SelectCharacter();
        else
            female_character_controller.SelectCharacter();
    }


    // Main Screen
    public void OnPlayButton()
    {
        
    }


    public void OnSelectCharacterButton()
    {
        ChangeScreen(select_character_screen);
    }

    public void OnExitButton()
    {

    }


    // Select Character
    public void SelectMainCharacter(MenuCharacterController character_controller)
    {
        if (character_controller.character_id == game_manager.character_selected)
            return;

        if(character_controller.character_id == 0)
        {
            male_character_controller.SelectCharacter();
            female_character_controller.DeselectCharacter();
        }
        else
        {
            female_character_controller.SelectCharacter();
            male_character_controller.DeselectCharacter();
        }
        game_manager.character_selected = character_controller.character_id;
    }
}
