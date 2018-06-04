using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class Highscores : MonoBehaviour
{
    [SerializeField]
    private Text displayText;

    private void Start()
    {
        var scores = ScoreSaveLoad.GetSaves();

        StringBuilder builder = new StringBuilder();
        builder.AppendLine("Highscores");
        for (int i = 0; i < scores.Count; i++)
        {
            var score = scores[i];
            builder.AppendLine(i + 1 + ". " + score.Name + " " + score.Value);
        }

        displayText.text = builder.ToString();
    }
}
