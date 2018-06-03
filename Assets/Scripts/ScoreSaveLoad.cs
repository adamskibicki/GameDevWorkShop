using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public static class ScoreSaveLoad
{
    [Serializable]
    public class Score
    {
        public int Value;
        public string Name;
    }

    [Serializable]
    private class ScoresContainer
    {
        public List<Score> Scores = new List<Score>();
    }

    private const string saveFileName = "fappyBird.save";

    private static ScoresContainer scoresContainer = new ScoresContainer();

    public static List<Score> GetSaves()
    {
        return scoresContainer.Scores;
    }

    public static void AddScore(Score score)
    {
        scoresContainer.Scores.Add(score);

        scoresContainer.Scores = scoresContainer.Scores
            .OrderByDescending(x => x.Value)
            .Take(3).ToList();
    }

    public static void Save()
    {
        try
        {
            string content = JsonUtility.ToJson(scoresContainer);

            File.WriteAllText(Application.persistentDataPath + "/" + saveFileName, content);
        }
        catch (Exception e)
        {
            Debug.Log(e);
        }
    }

    public static void Load()
    {
        try
        {
            if (File.Exists(Application.persistentDataPath + "/" + saveFileName))
            {
                string content = File.ReadAllText(Application.persistentDataPath + "/" + saveFileName);

                scoresContainer = JsonUtility.FromJson<ScoresContainer>(content);
            }
        }
        catch (Exception e)
        {
            Debug.Log(e);
        }
    }
}
