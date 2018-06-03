using UnityEngine;
using UnityEngine.SceneManagement;

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

    private void OnCollisionEnter2D(Collision2D other)
    {
        isDead = true;
        Invoke("EndGame", 1f);
    }

    private void EndGame()
    {
        ScoreSaveLoad.AddScore(new ScoreSaveLoad.Score
        {
            Name = "testname",
            Value = Score.Value
        });
        ScoreSaveLoad.Save();
        SceneManager.LoadScene("menu");
    }
}
