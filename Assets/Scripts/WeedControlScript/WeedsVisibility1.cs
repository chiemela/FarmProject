using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeedsVisibility1 : MonoBehaviour
{

    public string IsFixed = "";

    void Start()
    {
        // this makes the weeds to become invisible
        StoptHazard();
    }

    // this code will run when agent fixes the weed for a particular crop
    public void DetectWeedFixed(string AgentResponse)
    {

        IsFixed = AgentResponse;
        
    }

    // Update is called once per frame
    void Update()
    {

        // this makes the weeds to become visible
        if(Input.GetKeyUp(KeyCode.W))
        {

            StartHazard();

        }

    }

    void LateUpdate()
    {

        if(IsFixed == "FixedWeeds")
        {

            StoptHazard();

        }

    }
    
    // this makes the weeds visible
    public void StartHazard()
    {

        // this makes the weeds visible
        transform.localScale = new Vector3(0.08f, 0.11f, 0.08f);

    }

    // this kills the weeds
    public void StoptHazard()
    {

        // this kills the weeds
        transform.localScale = new Vector3(0.0001f, 0.0001f, 0.0001f);

    }
}