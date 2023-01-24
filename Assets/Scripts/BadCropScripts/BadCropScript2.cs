using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadCropScript2 : MonoBehaviour
{

    public Renderer myRenderer;
    string BadCropState = "";

    void Start()
    {
        myRenderer = gameObject.GetComponent<Renderer>();
    }
    // this accepts variables from other classes
    public void DetectKeyPress(string KeyPress)
    {

        BadCropState = KeyPress;

    }

    // Update is called once per frame
    void Update()
    {

        // this changes the colour to black
        if(Input.GetKeyUp(KeyCode.C))
        {

            // this sets the colour to black
            StartHazard();

        }

    }

    void LateUpdate()
    {

        if (BadCropState == "FixBadCrop")
        {

            // this sets the colour to black
            StopHazard();

        }
        // this will happen when the pests, flood or badsoil happens
        else if(BadCropState == "BadCrop")
        {
            // this will happen when the pests, flood or badsoil happens
            StartHazard();
        }

    }

    public void StartHazard()
    {

        // this sets the colour to black
        myRenderer.material.color = new Color(0, 0, 0);

    }

    public void StopHazard()
    {

        // this sets the colour to green
        Material newMat = Resources.Load("weatherSensor", typeof(Material)) as Material;
        gameObject.GetComponent<Renderer>().material = newMat;

    }

}