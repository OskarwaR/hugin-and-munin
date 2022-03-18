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
        float y;
        if (back)
        {
            spawn = 0;
            y = 2;
        }
            
        else
        {
            spawn = 1;
            y = 0.5f;
        }
            

        Transform posicion = spawns[spawn].transform;
        GameObject c=Instantiate(cloud, posicion.position + new Vector3(0, Random.Range(-y, y), 0), posicion.rotation);
        if(back)
            c.GetComponent<Cloud>().back = true;
        else
            c.GetComponent<Cloud>().back = false;
    }   
}
