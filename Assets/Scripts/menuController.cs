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
        UISound.instance.Reproducir(UISound.instance.rechazar);
        SceneManager.LoadScene("mainMenu");
    }

    public void QuitGame()
    {
        UISound.instance.Reproducir(UISound.instance.rechazar);
        Application.Quit();
    }

    public void midgard()
    {
        //Aquí va la escena del juego
        UISound.instance.Reproducir(UISound.instance.aceptar);
        SceneManager.LoadScene("midgardMenu");
    }

    public void Scene1()
    {
        //Aquí va la escena del juego
        UISound.instance.Reproducir(UISound.instance.aceptar);
        SceneManager.LoadScene("Game");
    }

    public void HideMenu()
    {
        UISound.instance.Reproducir(UISound.instance.aceptar);
        menu.active = false;
    }
}