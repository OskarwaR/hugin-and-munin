using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    Renderer rend;
    float value;

    public bool horizontal = true;

    [SerializeField] float parallaxVelocity;
    
    void Awake()
    {
        rend = GetComponent<Renderer>();
        if(horizontal)
            value = rend.material.mainTextureOffset.x;
        else
            value = rend.material.mainTextureOffset.y;
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
