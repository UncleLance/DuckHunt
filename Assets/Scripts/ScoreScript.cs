using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text scoreText;
    public int currentScore;

    public void ScoreUpdate(int score)
    {
        currentScore += score;
    }

    void Update()
    {
        scoreText.text = string.Format("Score: {0}", currentScore);
    }
}
