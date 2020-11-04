using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muis : MonoBehaviour
{
    public GameObject crosshair;
    private Vector3 target;
    // Start is called before the first frame update
    private AudioSource Audio;
    
    void Start()
    {
        Audio = GetComponent<AudioSource>();
        
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Audio.Play();
        }

        target = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
        crosshair.transform.position = new Vector2(target.x, target.y);
    }
}
