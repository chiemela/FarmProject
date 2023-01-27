using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarvestedFruitScript : MonoBehaviour
{

    public string IsHarvested = "";

    void Start()
    {
        // this method will make the harvested fruit at the store to be invisible
        FruitNotHarvested();
    }

    // this code will run when agent harvest's the fruit and delivers them to the store
    public void DetectFruitHarvested(string AgentResponse)
    {

        IsHarvested = AgentResponse;
        
    }

    void LateUpdate()
    {

        if(IsHarvested == "FruitIsHarvested")
        {

            FruitHarvested();

        }

    }
    
    // this method will make the harvested fruit at the store to be visible
    public void FruitHarvested()
    {

        transform.localScale = new Vector3(0.52f, 0.6200003f, 0.5200001f);

    }

    // this method will make the harvested fruit at the store to be invisible
    public void FruitNotHarvested()
    {

        transform.localScale = new Vector3(0.0001f, 0.0001f, 0.0001f);

    }
}