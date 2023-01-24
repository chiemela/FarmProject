using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadSoilScript : MonoBehaviour
{

    public Renderer myRenderer;
    string BadSoilState = "";
    public GameObject[] crop1;
    public GameObject[] crop2;
    public GameObject[] crop3;
    public GameObject[] crop4;

    void Start()
    {
        myRenderer = gameObject.GetComponent<Renderer>();
        crop1 = GameObject.FindGameObjectsWithTag("BadCrop1");
        crop2 = GameObject.FindGameObjectsWithTag("BadCrop2");
        crop3 = GameObject.FindGameObjectsWithTag("BadCrop3");
        crop4 = GameObject.FindGameObjectsWithTag("BadCrop4");
    }
    // this accepts variables from other classes
    public void DetectKeyPress(string KeyPress)
    {

        BadSoilState = KeyPress;

    }

    // Update is called once per frame
    void Update()
    {

        // this changes the colour to black
        if(Input.GetKeyUp(KeyCode.S))
        {

            // this sets the colour to black
            StartHazard();
            
            // this changes the crop colour to black
            foreach (GameObject a in crop1)
            {
                a.GetComponent<BadCropScript1>().DetectKeyPress("BadCrop");
            }
            foreach (GameObject a in crop2)
            {
                a.GetComponent<BadCropScript2>().DetectKeyPress("BadCrop");
            }
            foreach (GameObject a in crop3)
            {
                a.GetComponent<BadCropScript3>().DetectKeyPress("BadCrop");
            }
            foreach (GameObject a in crop4)
            {
                a.GetComponent<BadCropScript4>().DetectKeyPress("BadCrop");
            }

        }

    }

    void LateUpdate()
    {

        if (BadSoilState == "FixBadSoil")
        {

            // this sets the colour to black
            StopHazard();

            // this changes the crop colour to green
            foreach (GameObject a in crop1)
            {
                a.GetComponent<BadCropScript1>().DetectKeyPress("FixBadCrop");
            }
            foreach (GameObject a in crop2)
            {
                a.GetComponent<BadCropScript2>().DetectKeyPress("FixBadCrop");
            }
            foreach (GameObject a in crop3)
            {
                a.GetComponent<BadCropScript3>().DetectKeyPress("FixBadCrop");
            }
            foreach (GameObject a in crop4)
            {
                a.GetComponent<BadCropScript4>().DetectKeyPress("FixBadCrop");
            }

        }
        // this will happen when the pests, flood or badsoil happens
        else if(BadSoilState == "BadSoil")
        {
            // this will happen when the pests, flood or badsoil happens
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
        Material newMat = Resources.Load("planeColour", typeof(Material)) as Material;
        gameObject.GetComponent<Renderer>().material = newMat;

    }

}