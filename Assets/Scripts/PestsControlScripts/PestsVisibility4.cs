using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PestsVisibility4 : MonoBehaviour
{

    public string IsFixed = "";

    // this code will run when agent fixes the pest for a particular crop
    public void DetectPestsFixed(string AgentResponse)
    {

        IsFixed = AgentResponse;
        
    }

    void LateUpdate()
    {

        if(IsFixed == "FixedPests")
        {

            StoptHazard();

        }

    }

    // this kills the weeds
    public void StoptHazard()
    {

        // this kills the weeds
        transform.localScale = new Vector3(0.0001f, 0.0001f, 0.0001f);

    }
}