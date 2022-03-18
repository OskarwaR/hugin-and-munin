using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text runas;
    public GameObject controles;
    public AudioSource music;

    
    void Update()
    {
        runas.text = GameManager.instance.runasObtenidas.ToString();
    }

    public void StartGame()
    {
        music.Play();
        controles.active = false;
        Time.timeScale = 1;
    }
}
