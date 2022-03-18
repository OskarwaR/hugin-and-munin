using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    public float velocidad;
    public bool back = true;
    public bool aleatorio;

    private void Start()
    {
        if(aleatorio)
            GetComponent<SpriteRenderer>().sprite=
                SpawnManagerClouds.instance.clouds[Random.Range(0, SpawnManagerClouds.instance.clouds.Length)].
                    GetComponent<SpriteRenderer>().sprite;

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
