using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    Renderer rend;
    float value;

    [SerializeField] float parallaxVelocity;
    
    void Awake()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        if (!GameManager.instance.gameOver)
        {
            value += parallaxVelocity * Time.deltaTime;
            rend.material.mainTextureOffset = new Vector2(value, 0);
        }
    }
}
