using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour
{
    public Button button;
    public Text scoresText;
    public Text playersText;
    private List<string> playersList = new List<string>();
    private List<int> scoresList = new List<int>();

    void Awake()
    {
        button.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        SaveScript.Load();
        FileInfo[] savedData = SaveScript.saveFiles;

        List<ScoreScript.SaveScore> sortedData = new List<ScoreScript.SaveScore>();

        foreach (FileInfo playerData in savedData)
        {
            string data = File.ReadAllText(playerData.FullName);
            ScoreScript.SaveScore loadedData = JsonUtility.FromJson<ScoreScript.SaveScore>(data);

            sortedData.Add(loadedData);
        }

        sortedData.OrderByDescending(s => s.score).ToList();

        foreach(ScoreScript.SaveScore data in sortedData)
        {
            playersList.Add(data.playerName);
            scoresList.Add(data.score);
        }

        if (scoresText.text == "" && playersText.text == "")
        {
            for (int i = 0; i < scoresList.Count && i < playersList.Count; i++)
            {
                string score = string.Format("{0}\n", scoresList[i]);
                string player = string.Format("{0}\n", playersList[i]);

                scoresText.text += score;
                playersText.text += player;
            }
        }
    }
}
