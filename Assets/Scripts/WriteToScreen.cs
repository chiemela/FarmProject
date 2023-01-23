using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WriteToScreen : MonoBehaviour
{
    public TMP_Text UserFeedbackText;
    public GameObject[] agents;
    public GameObject[] pests1;
    public GameObject[] pests2;
    public GameObject[] pests3;
    public GameObject[] pests4;
    public GameObject[] pests5;
    public GameObject[] pests6;
    public GameObject[] pests7;
    public GameObject[] pests8;
    public GameObject[] pests9;
    public GameObject[] pests10;
    public GameObject[] pests11;
    public GameObject[] pests12;

    // Start is called before the first frame update
    
    void Start()
    {
        agents = GameObject.FindGameObjectsWithTag("Agent");
        pests1 = GameObject.FindGameObjectsWithTag("Pest1");
        pests2 = GameObject.FindGameObjectsWithTag("Pest2");
        pests3 = GameObject.FindGameObjectsWithTag("Pest3");
        pests4 = GameObject.FindGameObjectsWithTag("Pest4");
        pests5 = GameObject.FindGameObjectsWithTag("Pest5");
        pests6 = GameObject.FindGameObjectsWithTag("Pest6");
        pests7 = GameObject.FindGameObjectsWithTag("Pest7");
        pests8 = GameObject.FindGameObjectsWithTag("Pest8");
        pests9 = GameObject.FindGameObjectsWithTag("Pest9");
        pests10 = GameObject.FindGameObjectsWithTag("Pest10");
        pests11 = GameObject.FindGameObjectsWithTag("Pest11");
        pests12 = GameObject.FindGameObjectsWithTag("Pest12");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.S))
        {
            UserFeedbackText.text = "Soil is bad.";
        }
        
        if(Input.GetKeyUp(KeyCode.C))
        {
            UserFeedbackText.text = "Crop is bad.";
        }
        
        if(Input.GetKeyUp(KeyCode.W))
        {
            UserFeedbackText.text = "Weeds sprouting.";
            
            foreach (GameObject a in agents)
            {
                a.GetComponent<WayPointHarvestCrop>().DetectKeyPress("DestroyWeeds");
            }
        }
        
        if(Input.GetKeyUp(KeyCode.P))
        {
            // this displays "Pests invation." on the screen for the user to understand what's happening
            UserFeedbackText.text = "Pests invation.";
            
            // when user presses the "P" key then it will send the keypress to the method in the various classes as I have typed below
            foreach (GameObject a in pests1)
            {
                a.GetComponent<WayPointPest1EatCrop>().DetectKeyPress("Pest");
            }
            foreach (GameObject a in pests2)
            {
                a.GetComponent<WayPointPest2EatCrop>().DetectKeyPress("Pest");
            }
            foreach (GameObject a in pests3)
            {
                a.GetComponent<WayPointPest3EatCrop>().DetectKeyPress("Pest");
            }
            foreach (GameObject a in pests4)
            {
                a.GetComponent<WayPointPest4EatCrop>().DetectKeyPress("Pest");
            }
            foreach (GameObject a in pests5)
            {
                a.GetComponent<WayPointPest5EatCrop>().DetectKeyPress("Pest");
            }
            foreach (GameObject a in pests6)
            {
                a.GetComponent<WayPointPest6EatCrop>().DetectKeyPress("Pest");
            }
            foreach (GameObject a in pests7)
            {
                a.GetComponent<WayPointPest7EatCrop>().DetectKeyPress("Pest");
            }
            foreach (GameObject a in pests8)
            {
                a.GetComponent<WayPointPest8EatCrop>().DetectKeyPress("Pest");
            }
            foreach (GameObject a in pests9)
            {
                a.GetComponent<WayPointPest9EatCrop>().DetectKeyPress("Pest");
            }
            foreach (GameObject a in pests10)
            {
                a.GetComponent<WayPointPest10EatCrop>().DetectKeyPress("Pest");
            }
            foreach (GameObject a in pests11)
            {
                a.GetComponent<WayPointPest11EatCrop>().DetectKeyPress("Pest");
            }
            foreach (GameObject a in pests12)
            {
                a.GetComponent<WayPointPest12EatCrop>().DetectKeyPress("Pest");
            }
        }
        
        if(Input.GetKeyUp(KeyCode.E))
        {
            UserFeedbackText.text = "Flooding farm.";
        }
        
        if(Input.GetKeyUp(KeyCode.H))
        {
            UserFeedbackText.text = "Crop harvest.";
            
            foreach (GameObject a in agents)
            {
                a.GetComponent<WayPointHarvestCrop>().DetectKeyPress("Crop");
            }
            
        }
    }
    
}
