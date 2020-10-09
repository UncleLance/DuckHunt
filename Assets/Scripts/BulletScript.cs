using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BulletUpdateScript : MonoBehaviour
{
    private int bullets;
    private int incrementScore = 100;
    private int levelScore = 0;
    public Text bulletText;
    private ScoreScript score;

    void Awake()
    {
        score = GameObject.FindObjectOfType<ScoreScript>();
    }

    // Start is called before the first frame update
    void Start()
    {
        bullets = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if(bullets != 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                bullets--;
            }

            if (Input.GetMouseButtonDown(1))
            {
                levelScore += incrementScore;
                score.ScoreUpdate(incrementScore);

                if (levelScore % 500 == 0)
                {
                    bullets = 3;
                    levelScore = 0;
                }
            }

            bulletText.text = string.Format("Kogel: {0}", bullets);
        }
        else if(bullets >= 0)
        {
            bulletText.text = string.Format("Game over!");
        }
    }
}
