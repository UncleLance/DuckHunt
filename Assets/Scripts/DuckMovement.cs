using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class DuckMovement : MonoBehaviour
{
    public float speed;
    public Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        RandomDirection();
    }

    // Update is called once per frame
    void Update()
    {

        //direction = transform.position;

        //direction = direction * speed;

        //transform.position = direction;

        transform.position = transform.position + (direction * speed);

        //this.transform.position = new Vector3(direction * speed);

        //speed = 1f;
        //this.transform.position = this.transform.position new Vector3(speed * direction);
        //direction = transform.position(direction * speed);


    }

    public void RandomDirection()
    {
        direction = new Vector3(Random.Range(-1f, 1f), Random.Range(.2f, 1f), 0);
    }

    public void DirectionChanger(Vector3 _dir)
    {
        direction = new Vector3(direction.x * _dir.x, direction.y * _dir.y, 0);
    }

}
