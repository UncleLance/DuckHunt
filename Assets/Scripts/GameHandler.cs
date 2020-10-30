using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour
{
    public Button button;
    public Text text;
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

        foreach (FileInfo playerData in savedData)
        {
            string data = File.ReadAllText(playerData.FullName);
            ScoreScript.SaveScore loadedData = JsonUtility.FromJson<ScoreScript.SaveScore>(data);

            scoresList.OrderBy(player => loadedData.score).ToList();
            playersList.Add(loadedData.playerName);
            /*
            scoresList.Add(loadedData.score);
            playersList.Add(loadedData.playerName);
            */
        }

        if(playersList.Count > 0)
        {
            foreach (string playerName in playersList)
            {
                Debug.Log(playerName);
            }
        }
        else
        {
            Debug.Log("No players found!");
        }

        if(scoresList.Count > 0)
        {
            foreach (int playerScore in scoresList)
            {
                Debug.Log(playerScore);
            }

        }
        else
        {
            Debug.Log("No scores found!");
        }

        if (text.text == "")
        {
            for (int i = 0; i < scoresList.Count && i < playersList.Count; i++)
            {
                string data = string.Format("{0}          {1}\n", scoresList[i], playersList[i]);
                text.text += data;
            }
        }

        /*
        foreach (string score in scoreList)
        {
            string loadedScore = string.Format("{0} \n",  score);
            text.text += loadedScore;
        }
        */

    }
}
