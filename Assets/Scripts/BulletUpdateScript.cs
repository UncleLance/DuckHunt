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
        if (Input.GetMouseButtonDown(0))
        {
            bullets--;
        }
        else if (Input.GetMouseButtonDown(1))
        {
            bullets++;  
        }

        bulletText.text = "Kogel: " + bullets.ToString();
    }
}
