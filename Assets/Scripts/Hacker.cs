using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Hacker : MonoBehaviour
{
    int level;
    string pass;
    enum Screen { MainMenu, Password, Win};

    Screen CurrentScreen;
    void ShowMainMenu()
    {
        CurrentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("What would you like to hack into?");
        Terminal.WriteLine("Press 1 for the local library");
        Terminal.WriteLine("Press 2 for the police statin");
        Terminal.WriteLine("PLease enter your selection:");
    }
    void OnUserInput(string input)
    {
        if(input == "menu")
        {
            ShowMainMenu();
        }
        else if(CurrentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if(CurrentScreen == Screen.Password)
        {
            CheckPassword(input);
        }
        
    }
    void CheckPassword(string input)
    {
        if(input == pass)
        {
            Terminal.WriteLine("Welcome!");
        }
        else
        {
            Terminal.WriteLine("Wrong Password!");
        }
    }
    void RunMainMenu(string input)
    {
        if(input == "1")
        {
            level = 1;
            pass = "okbaby";
            StartGame();
        }
        else if(input == "2")
        {
            pass = "okbabe";
            level = 2;
            StartGame();
        }
        else
        {
            Terminal.WriteLine("Please chose a valid level");
        }
    }
    void StartGame()
    {
        CurrentScreen = Screen.Password;
        Terminal.WriteLine("You have choosen level "+ level);
        Terminal.WriteLine("Please Enter Your Password:");
    }
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
