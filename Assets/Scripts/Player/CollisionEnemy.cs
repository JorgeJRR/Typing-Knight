using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEnemy : MonoBehaviour
{
    public GameManager gameover;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Fireball")
        {
            gameover.GameOver();
        }
    }
}
