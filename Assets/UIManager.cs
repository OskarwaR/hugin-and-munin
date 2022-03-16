using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text runas;
    public Text valor;
    public Text nivel;

    void Update()
    {
        runas.text = "Runas: " + GameManager.instance.runasObtenidas.ToString();
        valor.text = "Valor Runa: " + GameManager.instance.valorRuna.ToString();
        nivel.text = "Nivel: " + GameManager.instance.runasObtenidas.ToString();
    }
}
