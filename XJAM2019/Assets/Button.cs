using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    //Game will go to the Game scene
    public void start()
    {
        SceneManager.LoadScene("Game");
    }
    //Game will close if you press quit
    public void quit()
    {
        Application.Quit();
    }
}

