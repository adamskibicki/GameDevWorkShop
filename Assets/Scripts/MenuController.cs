using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
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
}
