using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// class é um conjunto de métodos e variáveis (código)
public class Player : MonoBehaviour
{

    public float velocidade; // variavel de número decimais

    public float forcaPulo;

    public Rigidbody2D rb; //variavel do tipo componente rigdbody 2D

    public Animator anim;  
    
    bool estaPulando; //variavel do tipo verdadeiro ou falso



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movimentar();
        Pular();
    }


    void Movimentar()
    {
        float movimento = Input.GetAxis("Horizontal"); // varia entre -1 e 1 

        rb.velocity = new Vector2(movimento * velocidade, rb.velocity.y);

        if (movimento > 0)
        {
            transform.eulerAngles = new Vector2(0f, 0f);

            if(estaPulando == false)
            {
                anim.SetInteger("transition", 1);
            }
            
        }

        if (movimento < 0)
        {
            transform.eulerAngles = new Vector2(0f, 180f);

            if(estaPulando == false)
            {
                anim.SetInteger("transition", 1);
            }
            
        }

        if(movimento == 0)
        {
             if(estaPulando == false)
            {
                anim.SetInteger("transition", 0);
            }
        }

    }

    void Pular()
    {
        if(Input.GetButtonDown("Jump") && estaPulando == false)
        {
            rb.AddForce(new Vector2(0f, forcaPulo), ForceMode2D.Impulse);
            estaPulando = true;
            anim.SetInteger("transition", 2);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision) //detecta quando personagem detecta quando bate em outro colisor
    {
        //se colidir com o chão
        if(collision.gameObject.layer == 8)
        {
            estaPulando = false;
        }
    }
}
