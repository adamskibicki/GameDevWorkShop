using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;

    private bool isDead;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isDead)
        {
            rigidbody2D.velocity = new Vector2(0, 5);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        isDead = true;
    }
}
