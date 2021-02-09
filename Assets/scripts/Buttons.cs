using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public void NewGame()
    {
        Application.LoadLevel(1);
    }

    public void Menu()
    {
        Application.LoadLevel(0);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
