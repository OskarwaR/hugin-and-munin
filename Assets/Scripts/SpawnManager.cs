using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public static SpawnManager instance;
    public GameObject[] spawns;
    public GameObject[] runas;
    public List<GameObject> runasTemp = new List<GameObject>();

    private void Awake()
    {
        instance = this;
        foreach (GameObject r in runas)
        {
            runasTemp.Add(r);
        }
    }
    IEnumerator Start()
    {
        yield return new WaitForSecondsRealtime(4f);
        while (true)
        { 
            GameObject runa = runasTemp[Random.Range(0, runas.Length-1)];
            runasTemp.Clear();
            foreach (GameObject r in runas)
            {
                runasTemp.Add(r);
            }
            runasTemp.Remove(runa);
            Transform posicion = spawns[Random.Range(0, spawns.Length)].transform;
            Instantiate(runa,posicion.position + new Vector3(0,Random.Range(-0.2f,0.2f),0),posicion.rotation);
            yield return new WaitForSecondsRealtime(Random.Range(GameManager.instance.intervalo-0.5f, GameManager.instance.intervalo + 0.5f));
        } 
    }
}