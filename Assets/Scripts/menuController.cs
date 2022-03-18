using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuController : MonoBehaviour
{
    public void startMenu()
    {
        SceneManager.LoadScene("mainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void midgard()
    {
        //Aquí va la escena del juego
        SceneManager.LoadScene("----------------------");
    }
}