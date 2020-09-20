using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D rb;
    public float velocidade;
    public float timeInDirection;

    float tempo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tempo += Time.deltaTime;

        if(tempo >= timeInDirection)
        {
            velocidade = -velocidade;
            tempo = 0f;
        }

        //indo para direita
        if(velocidade > 0)
        {
            transform.eulerAngles = new Vector2(0f, 180f);
        }

        //indo para esquerda
        if(velocidade < 0)
        {
            transform.eulerAngles = new Vector2(0f, 0f);
        }

        rb.velocity = new Vector2(velocidade, rb.velocity.y);
    }
}
