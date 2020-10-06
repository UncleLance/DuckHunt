using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletUpdateScript : MonoBehaviour
{
    public int bullets;
    public Text bulletText;

    // Start is called before the first frame update
    void Start()
    {
        bullets = 3;
    }

    // Update is called once per frame
    void Update()
    {
        int score = GameObject.FindObjectOfType<Score> ();

        if (Input.GetMouseButtonDown(0))
        {
            bullets--;
        }

        if(score == 100)
        {
            bullets += 1;
        }

        bulletText.text = string.Format("Kogel: {0}", bullets);
    }
}
