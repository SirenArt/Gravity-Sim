using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    void Update()
    {
        //esc to exit game
        if(Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
