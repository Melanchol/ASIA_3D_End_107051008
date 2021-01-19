using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void QuitGame()
    {
        print("離開遊戲");
        Application.Quit();
    }
}
