using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text scoreText;
    public int currentScore;
    private InputScript inputScript;

    void Awake()
    {
        inputScript = FindObjectOfType<InputScript>();
    }

    void Update()
    {
        scoreText.text = string.Format("Score: {0}", currentScore);
    }
    
    public void ScoreUpdate(int score)
    {
        currentScore += score;
    }

    public class SaveScore
    {
        public int score;
        public string playerName;
    }
}
