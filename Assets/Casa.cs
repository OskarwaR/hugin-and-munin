using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Casa : MonoBehaviour
{
    public Image casa;
    public Text runas;

    private void Awake()
    {
        casa = GetComponent<Image>();
    }
    public void Comprar()
    {
        if(DataManager.instance.runas>=30)
        {
            DataManager.instance.runas -= 30;
            DataManager.instance.Save();

            casa.color = new Color(1, 1, 1, 1);

            runas.text = (int.Parse(runas.text)-30).ToString();
        }
    }
}
