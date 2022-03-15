using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runa : MonoBehaviour
{
    public float velocidad;

    private void Update()
    {
        velocidad = GameManager.instance.velocidadJuego;
        transform.Translate(-velocidad * Time.deltaTime, 0, 0);
    }
}


