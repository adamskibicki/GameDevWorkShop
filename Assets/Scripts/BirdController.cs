using UnityEngine;

public class BirdController : MonoBehaviour
{
    private new Rigidbody2D rigidbody2D;

    private bool isDead;

    private void Awake()
    {
        ScoreSaveLoad.Load();

        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) && !isDead)
        {
            rigidbody2D.velocity = new Vector2(0, 5);
        }
    }

    private void OnCollisionEnter2D()
    {
        isDead = true;
        GameController.Instance.PlayerFail();
    }
}
