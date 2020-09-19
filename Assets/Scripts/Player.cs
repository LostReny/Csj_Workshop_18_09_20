using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// class é um conjunto de métodos e variáveis (código)
public class Player : MonoBehaviour
{

    public float velocidade; // variavel de número decimais

    public Rigidbody2D rb; //variavel do tipo componente rigdbody 2D



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movimento = Input.GetAxis("Horizontal"); // varia entre -1 e 1 

        rb.velocity = new Vector2(movimento * velocidade, rb.velocity.y);
    }
}
