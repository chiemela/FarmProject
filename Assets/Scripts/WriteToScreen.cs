using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WriteToScreen : MonoBehaviour
{
    public TMP_Text UserFeedbackText;
    public TMP_Text AgentHealthText;
    public TMP_Text AgentStateText;
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
    public GameObject[] HarvestFruitScript1;
    public GameObject[] HarvestFruitScript2;
    public GameObject[] HarvestFruitScript3;
    public GameObject[] HarvestFruitScript4;
    public int AgentHealth = 100;

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
        HarvestFruitScript1 = GameObject.FindGameObjectsWithTag("FruitSet1");
        HarvestFruitScript2 = GameObject.FindGameObjectsWithTag("FruitSet2");
        HarvestFruitScript3 = GameObject.FindGameObjectsWithTag("FruitSet3");
        HarvestFruitScript4 = GameObject.FindGameObjectsWithTag("FruitSet4");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.S))
        {
            UserFeedbackText.text = "You pressed S key. Agent will get the organic fertilizers and apply to the soil.";
            AgentStateText.text = "Fix bad soil.";
            AgentHealthText.text = "100%";

            foreach (GameObject b in agents)
            {
                b.GetComponent<WayPointHarvestCrop>().DetectKeyPress("BadSoil");
            }
        }
        
        /*
        if(Input.GetKeyUp(KeyCode.C))
        {

            UserFeedbackText.text = "You pressed C key.";
            AgentStateText.text = "Fix bad crop.";
            AgentHealthText.text = "100%";

            foreach (GameObject b in agents)
            {
                b.GetComponent<WayPointHarvestCrop>().DetectKeyPress("BadCrop");
            }

        }
        */
        
        if(Input.GetKeyUp(KeyCode.W))
        {

            UserFeedbackText.text = "You pressed W key. Agent will apply environment-safe treatment around the crops.";
            AgentStateText.text = "Destroying weeds.";
            AgentHealthText.text = "100%";
            
            foreach (GameObject a in agents)
            {
                a.GetComponent<WayPointHarvestCrop>().DetectKeyPress("DestroyWeeds");
            }

        }
        
        if(Input.GetKeyUp(KeyCode.P))
        {

            // this displays "Pests invation." on the screen for the user to understand what's happening
            UserFeedbackText.text = "You pressed P key. Agent will get environment-safe pesticide to treat the farm.";
            AgentStateText.text = "Killing the pests.";
            AgentHealthText.text = "100%";
            
            // when user presses the "P" key then it will send the keypress to the method in the various classes as I have typed below
            foreach (GameObject a in pests1)
            {
                a.GetComponent<WayPointPest1EatCrop>().DetectKeyPress("Pest");

                foreach (GameObject b in agents)
                {
                    b.GetComponent<WayPointHarvestCrop>().DetectKeyPress("KillPests");
                }
                
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
                
            UserFeedbackText.text = "You pressed E key. Agent will check if the channel gate is open if not it will open it.";
            AgentStateText.text = "Make drainage f.";
            AgentHealthText.text = "100%";
            
            foreach (GameObject a in agents)
            {
                a.GetComponent<WayPointHarvestCrop>().DetectKeyPress("DrainErosion");
            }

        }
        
        if(Input.GetKeyUp(KeyCode.DownArrow))
        {
            UserFeedbackText.text = "You pressed Down arrow key. If health get's down to 25%, Agent will go to Lab to Repair itself.";
            if(AgentHealth > 25) 
            {
                AgentHealth = AgentHealth - 25;
            }
            if(AgentHealth < 50) 
            {
                AgentStateText.text = "System diagnosis and repair.";

                foreach (GameObject a in agents)
                {
                    a.GetComponent<WayPointHarvestCrop>().DetectKeyPress("SystemDiagnosis");
                }
            }
            AgentHealthText.text = (AgentHealth.ToString()) + "%";
            
        }
        
        if(Input.GetKeyUp(KeyCode.G))
        {

            UserFeedbackText.text = "You pressed G key. Fruits has now matured and are ready for harvest. Agent will pluck them with Robot arm and take them to the store.";
            AgentStateText.text = "Harvesting the crops.";
            AgentHealthText.text = "100%";

            
            foreach (GameObject a in agents)
            {
                a.GetComponent<WayPointHarvestCrop>().DetectKeyPress("Crop");
            }

            foreach (GameObject a in HarvestFruitScript1)
            {
                a.GetComponent<HarvestFruitScript1>().MakeFruitGrow("FruitGrow");
            }

            foreach (GameObject a in HarvestFruitScript2)
            {
                a.GetComponent<HarvestFruitScript2>().MakeFruitGrow("FruitGrow");
            }

            foreach (GameObject a in HarvestFruitScript3)
            {
                a.GetComponent<HarvestFruitScript3>().MakeFruitGrow("FruitGrow");
            }

            foreach (GameObject a in HarvestFruitScript4)
            {
                a.GetComponent<HarvestFruitScript4>().MakeFruitGrow("FruitGrow");
            }
            
        }
        
        if(Input.GetKeyUp(KeyCode.V))
        {

            UserFeedbackText.text = "You pressed V key. Agent is patrolling close to the crops.";
            AgentStateText.text = "Patrol";
            AgentHealthText.text = "100%";

            
            foreach (GameObject a in agents)
            {
                a.GetComponent<WayPointHarvestCrop>().DetectKeyPress("AgentPatrolTag");
            }
            
        }

    }
    
}
