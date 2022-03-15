using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public static SpawnManager instance;
    public GameObject[] spawns;
    public GameObject[] runas;

    private void Awake()
    {
        instance = this;
    }
    IEnumerator Start()
    {
        yield return new WaitForSecondsRealtime(4f);
        while (true)
        { 
            GameObject runa = runas[Random.Range(0, runas.Length)];
            Transform posicion = spawns[Random.Range(0, spawns.Length)].transform;
            Instantiate(runa,posicion.position,posicion.rotation);
            yield return new WaitForSecondsRealtime(Random.Range(2.5f,4.5f));
        } 
    }
}
