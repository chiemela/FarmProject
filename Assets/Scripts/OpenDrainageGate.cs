using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDrainageGate : MonoBehaviour
{

    string FloodFarm = "";

    // this code will run when user presses "E" on the keyboard and Agent reaches the drainage gate
    public void DetectKeyPress(string KeyPress)
    {

        FloodFarm = KeyPress;

    }

    void LateUpdate()
    {

        if (FloodFarm == "DrainageGate")
        {

            // this open the drain gate
            transform.localScale = new Vector3(0.0001f, 0.0001f, 0.0001f);

        }

    }
    
}
