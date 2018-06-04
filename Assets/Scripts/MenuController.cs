using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] private GameObject MainMenu;
    [SerializeField] private GameObject HighscoresMenu;

    private void Awake()
    {
        ScoreSaveLoad.Load();
    }

    public void Play()
    {
        SceneManager.LoadScene("scene1");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void GoToHighscores()
    {
        MainMenu.SetActive(false);
        HighscoresMenu.SetActive(true);
    }

    public void GoToMenu()
    {
        HighscoresMenu.SetActive(false);
        MainMenu.SetActive(true);
    }
}
