using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarvestFruitScript3 : MonoBehaviour
{

    string HarvestCrop = "";
    string FruitGrow = "";

    void Start()
    {

        // this makes the fruit invisible
        FruitHarvested();

    }

    // this code will run when user presses "H" on the keyboard
    public void DetectKeyPress(string KeyPress)
    {

        HarvestCrop = KeyPress;

    }

    // this code will run when user presses "G" on the keyboard
    public void MakeFruitGrow(string KeyPress)
    {

        FruitGrow = KeyPress;

    }

    void LateUpdate()
    {

        if (HarvestCrop == "FruitSet3")
        {

            // this makes the fruit invisible
            FruitHarvested();
            HarvestCrop = "";
        }

        if (FruitGrow == "FruitGrow")
        {

            // this makes the fruit invisible
            FruitMatured();
            FruitGrow = "";
        }

    }

    public void FruitMatured()
    {

        // this makes the fruit visible
        transform.localScale = new Vector3(0.52f, 2.479999f, 0.5200002f);

    }

    public void FruitHarvested()
    {

        // this makes the fruit invisible
        transform.localScale = new Vector3(0.0001f, 0.0001f, 0.0001f);

    }

}