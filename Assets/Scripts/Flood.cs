using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flood : MonoBehaviour
{

    string FloodFarm = "";

    // this code will run when user presses "E" on the keyboard and Agent reaches the solution store
    public void DetectKeyPress(string KeyPress)
    {

        FloodFarm = KeyPress;

    }

    // Update is called once per frame
    void Update()
    {

        // this brings the flood up
        if(Input.GetKeyUp(KeyCode.E))
        {

            StartHazard();

        }

    }

    void LateUpdate()
    {

        if (FloodFarm == "AfterDrainageGate")
        {

            // this makes the flood invisible
            StoptHazard();

        }

    }

    public void StartHazard()
    {

        // this makes the flood visible
        transform.localScale = new Vector3(2.08f, 1f, 2.57f);

    }

    public void StoptHazard()
    {

        // this drains the flood
        transform.localScale = new Vector3(0.0001f, 0.0001f, 0.0001f);

    }

}
