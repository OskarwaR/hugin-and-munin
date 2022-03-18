using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    Renderer rend;
    float value;

    public bool horizontal = true;
    public bool aleatorio = false;

    [SerializeField] float parallaxVelocity;
    
    void Awake()
    {
        rend = GetComponent<Renderer>();
        if(horizontal)
            value = rend.material.mainTextureOffset.x;
        else
            value = rend.material.mainTextureOffset.y;

        if (aleatorio)
            value = Random.Range(0f, 1f);
    }

    void Update()
    {
        value += parallaxVelocity * Time.deltaTime;
        if (horizontal)
        {
            rend.material.mainTextureOffset = new Vector2(value, 0);
        }
        else
        {
            rend.material.mainTextureOffset = new Vector2(0, value);
        }
        
    }
}
