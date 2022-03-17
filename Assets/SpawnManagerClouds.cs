using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerClouds : MonoBehaviour
{
    public static SpawnManagerClouds instance;
    public GameObject[] spawns;
    public GameObject[] clouds;

    private void Awake()
    {
        instance = this;
    }

    public void NewCloud(bool back)
    {
        GameObject cloud = clouds[Random.Range(0, clouds.Length - 1)];
        
        int spawn;
        if (back)
            spawn = 0;
        else
            spawn = 1;

        Transform posicion = spawns[spawn].transform;
        GameObject c=Instantiate(cloud, posicion.position + new Vector3(0, Random.Range(-2f, 2f), 0), posicion.rotation);
        if(back)
            c.GetComponent<Cloud>().back = true;
        else
            c.GetComponent<Cloud>().back = false;
    }   
}
