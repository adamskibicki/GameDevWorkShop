using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject scorePanel;
    [SerializeField] private InputField scoreInput;
    [SerializeField] private ColumnsSpawner columnsSpawner;
    [SerializeField] private AutoScroller[] scrollers;

    private static GameController instance;

    public static GameController Instance
    {
        get
        {
            if (!instance)
            {
                instance = FindObjectOfType<GameController>();
            }

            return instance;
        }
    }

    public void SaveScore()
    {
        ScoreSaveLoad.AddScore(new ScoreSaveLoad.Score
        {
            Name = scoreInput.text,
            Value = Score.Value
        });

        ScoreSaveLoad.Save();

        SceneManager.LoadScene("menu");
    }

    public void PlayerFail()
    {
        columnsSpawner.StopAllColumns();

        foreach (var scroller in scrollers)
        {
            scroller.Stop();
        }

        ShowScorePanel();
    }

    private void ShowScorePanel()
    {
        scorePanel.SetActive(true);
    }
}
