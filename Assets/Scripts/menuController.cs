using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuController : MonoBehaviour
{
    public GameObject menu;
    public Text runas;

    private void Start()
    {
        if(runas)
            runas.text = DataManager.instance.runas.ToString();
    }

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
        SceneManager.LoadScene("midgardMenu");
    }

    public void Scene1()
    {
        //Aquí va la escena del juego
        SceneManager.LoadScene("Game");
    }

    public void HideMenu()
    {
        menu.active = false;
    }
}