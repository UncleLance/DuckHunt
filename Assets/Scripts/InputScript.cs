using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputScript : MonoBehaviour
{
    public Button submitButton;
    public InputField inputField;
    public string playerName;
    private BulletScript bulletScript;
    private ScoreScript scoreScript;

    void Awake()
    {
        scoreScript = FindObjectOfType<ScoreScript>();
        bulletScript = FindObjectOfType<BulletScript>();

        submitButton.onClick.AddListener(OnClick);

        Hide();
    }

    void OnClick()
    {
        playerName = inputField.text;
        bulletScript.bullets = 3;
       
        ScoreScript.SaveScore saveScore = new ScoreScript.SaveScore
        {
            score = scoreScript.currentScore,
            playerName = playerName
        };

        string json = JsonUtility.ToJson(saveScore);

        SaveScript.Save(json);

        Debug.Log(string.Format("Score: {0} | Naam: {1}",
                                scoreScript.currentScore, playerName));

        scoreScript.currentScore = 0;
        inputField.text = "";

        Hide();
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }
}
