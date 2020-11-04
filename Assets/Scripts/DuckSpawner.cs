using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckSpawner : MonoBehaviour
{
    public GameObject Duck;

    // Start is called before the first frame update
/*    void Start()
    {
        
    }*/

    // Update is called once per frame
/*    void Update()
    {
        
    }*/

    public void SpawnDuck()
    {
        Instantiate(Duck, transform.position, Quaternion.identity);
    }

}

/*Spawner d = Instantiate(Duck) as Spawner;
d.transform.position */