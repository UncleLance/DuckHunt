using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionChanger : MonoBehaviour
{
    public enum DirChanger { Horizontal, Vertical};
    public DirChanger changer;

    private DuckMovement duckMovement;
    

    // Start is called before the first frame update
    /*void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
/*    void OnCollisionEnter(Collision hit)
    {    
        if (hit.transform.tag == "Duck")
        {
            duckMovement = GetComponent<DuckMovement>();

            if (changer == DirChanger.Horizontal)
             {
                duckMovement.DirectionChanger new Vector3(-1, 1, 0);
             }
             else if (changer == DirChanger.Vertical)
             {
                 duckMovement.DirectionChanger new Vector3(1, -1, 0);
             }
        }
    }*/
}
