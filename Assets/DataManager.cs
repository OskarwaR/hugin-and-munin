using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager instance;
    public int runas;

    private void Awake()
    {
        instance = this;
        if (PlayerPrefs.HasKey("runas"))
        {
            runas = PlayerPrefs.GetInt("runas");
        }
        else
        {
            PlayerPrefs.SetInt("runas", 0);
            runas = 0;
        }
    }
    void Start()
    {
        
    }

    public void Save()
    {
        PlayerPrefs.SetInt("runas", runas);
    }
}