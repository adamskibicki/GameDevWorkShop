using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnsCOntroller : MonoBehaviour
{

    private Rigidbody2D rigidbody2D;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        rigidbody2D.velocity = new Vector2(-2, 0);
    }


}
