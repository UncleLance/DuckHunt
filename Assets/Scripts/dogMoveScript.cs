﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogMoveScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(0, -240);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 1 * Time.deltaTime);
    }

    void moveUp()
    {
      //  transform.position += new Vector3(1 * Time.deltaTime, 0, 0);
    }
}
