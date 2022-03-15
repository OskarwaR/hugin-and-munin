using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool android;
    public bool gameOver = false;
    [Space][Space]
    public float velocidadJuego = 0;
    public float velocidadJuegoBase = 0.5f;
    public float velocidadJuegoT1 = 1;
    public float velocidadJuegoT2 = 1.75f;
    public float velocidadJuegoT3 = 2.5f;
    [Space][Space]
    public float intervalo = 0;
    public float intervalo1 = 4f;
    public float intervalo2 = 3f;
    public float intervalo3 = 2f;
    [Space][Space]
    public int runasObtenidas = 0;
    public int valorRuna = 1;
    public int tier1 = 16;
    public int tier2 = 35;

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
        if (runasObtenidas <= tier1)
        {
            valorRuna = 1;
            velocidadJuego = velocidadJuegoBase + velocidadJuegoT1;
            intervalo = intervalo1;
        }
        else if (runasObtenidas > tier1 && runasObtenidas <= tier2)
        {
            valorRuna = 2;
            if (velocidadJuego < (velocidadJuegoBase + velocidadJuegoT2))
            {
                velocidadJuego += 0.1f * Time.deltaTime;
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
                velocidadJuego += 0.1f * Time.deltaTime;
                if (velocidadJuego > (velocidadJuegoBase + velocidadJuegoT3))
                    velocidadJuego = velocidadJuegoBase + velocidadJuegoT3;
            }
            intervalo = intervalo3;
        }
    }
}
