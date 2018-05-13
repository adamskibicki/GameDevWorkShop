using UnityEngine;

public class ColumnsController : MonoBehaviour
{
    private new Rigidbody2D rigidbody2D;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        rigidbody2D.velocity = new Vector2(-2, 0);
    }

    private void OnEnable()
    {
        rigidbody2D.velocity = new Vector2(-2, 0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Score.Value++;
    }
}
