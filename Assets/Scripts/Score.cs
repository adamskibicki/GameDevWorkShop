using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int Value;

    [SerializeField]
    private Text scoreText;

    public void Update()
    {
        scoreText.text = "Score: "+ Value;
    }
}
