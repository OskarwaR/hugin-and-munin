using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limites : MonoBehaviour
{
    public static Limites instance;

    public Transform limiteUp;
    public Transform limiteDown;
    public Transform limiteLeft;
    public Transform limiteRight;

    private void Awake()
    {
        instance = this;
    }
}
