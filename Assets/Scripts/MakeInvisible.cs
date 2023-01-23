using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeInvisible : MonoBehaviour
{
    void Start()
    {
        // this makes the weeds to become invisible
        transform.localScale = new Vector3(0.0001f, 0.0001f, 0.0001f);
    }

    // Update is called once per frame
    void Update()
    {
        // this makes the weeds to become visible
        if(Input.GetKeyUp(KeyCode.W))
        {
            transform.localScale = new Vector3(0.08f, 0.11f, 0.08f);
        }
    }
}
