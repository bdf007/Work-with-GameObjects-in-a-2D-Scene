using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizePosition : MonoBehaviour
{
    public Rigidbody2D ball;
    public Collider2D ballCollider;
    private float x;
    private float y = 4.5f;

    void Start()
    {
        ball = GameObject.Find("Ball").GetComponent<Rigidbody2D>();
        ballCollider = GameObject.Find("Ball").GetComponent<Collider2D>();
        x = Random.Range(-1.9f, 1.9f);
        ball.transform.position = new Vector2(x, y);
    }

    void FixedUpdate()
    {
       // check if the y position don't change during 2sec
         if (ball.velocity.y == 0)
         {
              // if the y position don't change during 2sec, the ball is stuck
              if (ball.velocity.x == 0)
              {
                x = Random.Range(-1.9f, 1.9f);
                ball.transform.position = new Vector2(x, y);
              }
         }
    }

    void Update()
    {
        if (ballCollider.IsTouchingLayers(LayerMask.GetMask("Ground")))
        {
            x = Random.Range(-1.9f, 1.9f);
            ball.transform.position = new Vector2(x, y);
        }
    }

}
