using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool android;
    public bool gameOver = false;
    [Space(10)]
    [Header("Velocidad del juego segun el nivel")]
    public float velocidadJuego = 0;
    public float velocidadJuegoBase = 0.5f;
    public float velocidadJuegoT1 = 1;
    public float velocidadJuegoT2 = 1.75f;
    public float velocidadJuegoT3 = 2.5f;
    [Space(10)]
    [Header("Intervalo de aparicion de runas en segundos")]
    public float intervalo = 0;
    public float intervalo1 = 4f;
    public float intervalo2 = 3f;
    public float intervalo3 = 2f;
    [Space(10)]
    [Header("Runas necesarias para aunmentar el nivel")]
    public int runasObtenidas = 0;
    public int valorRuna = 1;
    public int tier2 = 16;
    public int tier3 = 35;

    [HideInInspector]
    public int players = 2;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        RunasObtenidas();
    }

    private void RunasObtenidas()
    {
        if (runasObtenidas <= tier2)
        {
            valorRuna = 1;
            velocidadJuego = velocidadJuegoBase + velocidadJuegoT1;
            intervalo = intervalo1;
        }
        else if (runasObtenidas > tier2 && runasObtenidas <= tier3)
        {
            valorRuna = 2;
            if (velocidadJuego < (velocidadJuegoBase + velocidadJuegoT2))
            {
                velocidadJuego += 0.2f * Time.deltaTime;
                if (velocidadJuego > (velocidadJuegoBase + velocidadJuegoT2))
                    velocidadJuego = velocidadJuegoBase + velocidadJuegoT2;
            }
            intervalo = intervalo2;
        }
        else
        {
            valorRuna = 3;
            if (velocidadJuego < (velocidadJuegoBase + velocidadJuegoT3))
            {
                velocidadJuego += 0.2f * Time.deltaTime;
                if (velocidadJuego > (velocidadJuegoBase + velocidadJuegoT3))
                    velocidadJuego = velocidadJuegoBase + velocidadJuegoT3;
            }
            intervalo = intervalo3;
        }
    }

    public void GameOver()
    {
        if (players == 0)
            StartCoroutine(Reset());
    }

    IEnumerator Reset()
    {
        yield return new WaitForSecondsRealtime(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
