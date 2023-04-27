using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisapearCoin : MonoBehaviour
{
    public Collider2D ball;
    public Collider2D jar;

    void Start()
    {
        ball = GameObject.Find("Ball").GetComponent<Collider2D>();
        jar = GameObject.Find("Jar").GetComponent<Collider2D>();
    }

    void Update()
    {
        //destroy ball when it collides with jar
        if (ball.IsTouching(jar))
        {
            Destroy(ball.gameObject);
        }
    }

}
