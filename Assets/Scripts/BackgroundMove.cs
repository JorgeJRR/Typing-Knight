using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    public float backgroundSpeed;

    void Update()
    {
        if(GameManager.Instance.gameOver == false)
        {
            transform.Translate(Vector3.left * backgroundSpeed * Time.deltaTime);
        }
        if (transform.position.x <= -8.85f)
        {
            transform.position = new Vector3(8.85f, transform.position.y, transform.position.z);
        }
    }
}
