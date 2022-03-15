using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool android;
    public bool gameOver = false;
    public float velocidadJuego=1;
    public int runasObtenidas=0;
    public int valorRuna = 1;
    public int tier1=16;
    public int tier2 = 35;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        if(runasObtenidas<=tier1)
        {
            valorRuna = 1;
            velocidadJuego = 1;
        }
        else if(runasObtenidas>tier1 && runasObtenidas<=tier2)
        {
            valorRuna = 2;
            velocidadJuego = 1.75f;
        }
        else
        {
            valorRuna = 3;
            velocidadJuego = 2.5f;
        }
    }
}
