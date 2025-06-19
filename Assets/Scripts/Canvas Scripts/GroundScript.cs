using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour
{

    public Rigidbody2D _rb;
    public float speed;
    public bool gameOver;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver == false)
        {
            speed = -2f;
        }
        else speed = 0;

        _rb.velocity = new Vector2(speed, _rb.velocity.y);
    }
}
