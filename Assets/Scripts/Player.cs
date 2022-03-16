using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Joystick joystick;
    Rigidbody2D rb;

    public bool player1;
    public bool player2;
    public float moveSpeed;

    float horizontalMove;
    float verticalMove;
    Vector2 movement;
    Vector2 newPos;

    private void Awake()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Controles();
    }

    private void Controles()
    {
        if (GameManager.instance.android)
        {
            movement.x = joystick.Horizontal;
            movement.y = joystick.Vertical;
        }
        else
        {
            if (player1)
            {
                movement.x = Input.GetAxisRaw("Horizontal");
                movement.y = Input.GetAxisRaw("Vertical");
            }
            else
            {
                movement.x = Input.GetAxisRaw("Horizontal2");
                movement.y = Input.GetAxisRaw("Vertical2");
            }

        }

        movement = Vector2.ClampMagnitude(movement, 1);
    }

    private void FixedUpdate()
    {
        newPos = rb.position + movement * moveSpeed * Time.fixedDeltaTime;
        ComprobarLimites();

        rb.MovePosition(newPos);
    }

    private void ComprobarLimites()
    {
        if (newPos.y > Limites.instance.limiteUp.position.y)
            newPos.y = Limites.instance.limiteUp.position.y;

        if (newPos.y < Limites.instance.limiteDown.position.y)
            newPos.y = Limites.instance.limiteDown.position.y;

        if (newPos.x < Limites.instance.limiteLeft.position.x)
            newPos.x = Limites.instance.limiteLeft.position.x;

        if (newPos.x > Limites.instance.limiteRight.position.x)
            newPos.x = Limites.instance.limiteRight.position.x;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer==LayerMask.NameToLayer("Runa"))
        {
            if(collision.CompareTag("Roja"))
            {
                PajaroMuerto();
            }
            else
            {
                if(player1)
                {
                    if(collision.CompareTag("Blanca"))
                    {
                        CogerRuna(collision);
                    }
                    else
                    {
                        PajaroMuerto();
                    }
                }
                else if(player2)
                {
                    if (collision.CompareTag("Negra"))
                    {
                        CogerRuna(collision);
                    }
                    else
                    {
                        PajaroMuerto();
                    }
                }
            }
        }
    }

    private static void CogerRuna(Collider2D collision)
    {
        GameManager.instance.runasObtenidas += GameManager.instance.valorRuna;
        collision.GetComponent<Runa>().StartCoroutine(collision.GetComponent<Runa>().Fade());
    }

    private void PajaroMuerto()
    {
        Destroy(this.gameObject);
    }
}
