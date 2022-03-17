using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    public float velocidad;
    public bool back = true;

    private void Start()
    {
        if (back)
            velocidad = 0.05f;
        else
            velocidad = 0.5f;
    }
    private void Update()
    {
        transform.Translate(-velocidad * Time.deltaTime, 0, 0);
    }
}
