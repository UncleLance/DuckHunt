using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuLoad : MonoBehaviour
{
    public void LoadLevel(string _name)
    {
        Application.LoadLevel(_name);
    }
}
