using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runa : MonoBehaviour
{
    public float velocidad;
    bool activa = true;
    SpriteRenderer sprite;
    

    private void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (!activa) return;
        velocidad = GameManager.instance.velocidadJuego;
        transform.Translate(-velocidad * Time.deltaTime, 0, 0);
    }

    public IEnumerator Fade()
    {
        activa = false;
        float a=1f;
        transform.position = new Vector3(transform.position.x,transform.position.y,-11);
        while (a>0)
        {
            a -= Time.deltaTime;
            sprite.color = new Color(1f, 1f, 1f, a);
            transform.localScale = new Vector2(transform.localScale.x + Time.deltaTime, transform.localScale.y + Time.deltaTime);
            yield return null;
        }
        Destroy(this.gameObject);
    }
}


