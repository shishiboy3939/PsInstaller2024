
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0f, 0f, -0.1f);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0f, 0f, 0.1f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
         transform.Translate(-0.1f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(0.1f, 0f, 0f);
        }
        // if (Input.GetKey(KeyCode.D))
        // {
        //     transform.Rotate(0f, 2f, 0f); // y軸を軸として90°回転
        // }
        // if (Input.GetKey(KeyCode.A)) // Input.GetKeyDown(KeyCode.左)
        // {
        //     transform.Rotate(0f, -2f, 0f); // y軸を軸として90°回転
        // }
    }

}