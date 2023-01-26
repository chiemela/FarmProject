using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WayPointHarvestCrop : MonoBehaviour
{
    public GameObject[] waypoints;
    public GameObject[] drainage;
    public GameObject[] afterdrainage;
    public GameObject[] crop1;
    public GameObject[] crop2;
    public GameObject[] crop3;
    public GameObject[] crop4;
    public GameObject[] BadSoilObject;
    public GameObject[] HarvestFruitScript1;
    public GameObject[] HarvestFruitScript2;
    public GameObject[] HarvestFruitScript3;
    public GameObject[] HarvestFruitScript4;
    int currentWP = 0;
    int temp_currentWP =  0;
    float speed = 4.0f;
    float accuracy = 1.0f;
    float rotSpeed = 3.0f;
    string SetWayPoints = "";
    bool MakeDrain = false;
    bool AfterMakeDrain = false;

    // Start is called before the first frame update
    void Start()
    {
        drainage = GameObject.FindGameObjectsWithTag("DrainageGate");
        afterdrainage = GameObject.FindGameObjectsWithTag("AfterDrainageGate");
        crop1 = GameObject.FindGameObjectsWithTag("BadCrop1");
        crop2 = GameObject.FindGameObjectsWithTag("BadCrop2");
        crop3 = GameObject.FindGameObjectsWithTag("BadCrop3");
        crop4 = GameObject.FindGameObjectsWithTag("BadCrop4");
        BadSoilObject = GameObject.FindGameObjectsWithTag("BadSoil");
        HarvestFruitScript1 = GameObject.FindGameObjectsWithTag("FruitSet1");
        HarvestFruitScript2 = GameObject.FindGameObjectsWithTag("FruitSet2");
        HarvestFruitScript3 = GameObject.FindGameObjectsWithTag("FruitSet3");
        HarvestFruitScript4 = GameObject.FindGameObjectsWithTag("FruitSet4");
        // this sets the initial Waypoint to "Crop"
        // waypoints = GameObject.FindGameObjectsWithTag("DestroyWeeds");
    }

    // this code will run when user presses "H" on the keyboard
    public void DetectKeyPress(string KeyPress)
    {
        SetWayPoints = KeyPress;
        // this sets a new Waypoint to whatever input passed from "WriteToScreen.cs"
        waypoints = GameObject.FindGameObjectsWithTag(SetWayPoints);
        currentWP = 0;
    }

    public void HandleBadCrop()
    {
        waypoints = GameObject.FindGameObjectsWithTag("KillPests");
    }

    // LateUpdate is called once per frame
    void LateUpdate()
    {

        // Agent does this if user presses "H" key on the keyboard
        if (SetWayPoints == "Crop")
        {

            if (waypoints.Length == 0) return;
            
            Vector3 lookAtGoal = new Vector3(waypoints[currentWP].transform.position.x, this.transform.position.y, waypoints[currentWP].transform.position.z);

            Vector3 direction = lookAtGoal - this.transform.position;

            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * rotSpeed);

            
            if (direction.magnitude < accuracy)
            {

                if(currentWP == 0)
                {
                    
                    foreach (GameObject a in HarvestFruitScript1)
                    {
                        a.GetComponent<HarvestFruitScript1>().DetectKeyPress("FruitSet1");
                    }
                    
                }
                if(currentWP == 1)
                {
                    
                    foreach (GameObject a in HarvestFruitScript2)
                    {
                        a.GetComponent<HarvestFruitScript2>().DetectKeyPress("FruitSet2");
                    }
                    
                }
                if(currentWP == 2)
                {
                    
                    foreach (GameObject a in HarvestFruitScript3)
                    {
                        a.GetComponent<HarvestFruitScript3>().DetectKeyPress("FruitSet3");
                    }
                    
                }
                if(currentWP == 3)
                {
                    
                    foreach (GameObject a in HarvestFruitScript4)
                    {
                        a.GetComponent<HarvestFruitScript4>().DetectKeyPress("FruitSet4");
                    }
                    
                }
                
                temp_currentWP = currentWP;
                currentWP++;
                if (currentWP >= waypoints.Length)
                {
                    currentWP = temp_currentWP;
                    // currentWP = 0;
                }
                
            }
            
            this.transform.Translate(0, 0, speed * Time.deltaTime);

        }

        // Agent does this if user presses "W" key on the keyboard
        else if (SetWayPoints == "DestroyWeeds")
        {
            
            if (waypoints.Length == 0) return;
                
            Vector3 lookAtGoal = new Vector3(waypoints[currentWP].transform.position.x, this.transform.position.y, waypoints[currentWP].transform.position.z);

            Vector3 direction = lookAtGoal - this.transform.position;

            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * rotSpeed);

            
            if (direction.magnitude < accuracy)
            {
                
                temp_currentWP = currentWP;
                currentWP++;
                if (currentWP >= waypoints.Length)
                {
                    currentWP = temp_currentWP;
                    // currentWP = 0;
                }
                
            }
            
            this.transform.Translate(0, 0, speed * Time.deltaTime);

        }

        // Agent does this if user presses "P" key on the keyboard
        else if (SetWayPoints == "KillPests")
        {

            if (waypoints.Length == 0) return;
            
            Vector3 lookAtGoal = new Vector3(waypoints[currentWP].transform.position.x, this.transform.position.y, waypoints[currentWP].transform.position.z);

            Vector3 direction = lookAtGoal - this.transform.position;

            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * rotSpeed);

            
            if (direction.magnitude < accuracy)
            {
                
                temp_currentWP = currentWP;
                currentWP++;
                if (currentWP >= waypoints.Length)
                {
                    currentWP = temp_currentWP;
                    // currentWP = 0;
                }
                
            }
            
            this.transform.Translate(0, 0, speed * Time.deltaTime);

        }

        // Agent does this when "AgentHealth" gets to 25%
        else if (SetWayPoints == "SystemDiagnosis")
        {

            if (waypoints.Length == 0) return;
            
            Vector3 lookAtGoal = new Vector3(waypoints[currentWP].transform.position.x, this.transform.position.y, waypoints[currentWP].transform.position.z);

            Vector3 direction = lookAtGoal - this.transform.position;

            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * rotSpeed);

            
            if (direction.magnitude < accuracy)
            {
                
                temp_currentWP = currentWP;
                currentWP++;
                if (currentWP >= waypoints.Length)
                {
                    currentWP = temp_currentWP;
                    // currentWP = 0;
                }
                
            }
            
            this.transform.Translate(0, 0, speed * Time.deltaTime);

        }

        // Agent does this when farm gets flooded
        else if (SetWayPoints == "DrainErosion")
        {

            if (waypoints.Length == 0) return;
            
            Vector3 lookAtGoal = new Vector3(waypoints[currentWP].transform.position.x, this.transform.position.y, waypoints[currentWP].transform.position.z);

            Vector3 direction = lookAtGoal - this.transform.position;

            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * rotSpeed);

            
            if (direction.magnitude < accuracy)
            {
                if(!MakeDrain)
                {
                    MakeDrain = true;
                    
                    foreach (GameObject a in drainage)
                    {
                        a.GetComponent<OpenDrainageGate>().DetectKeyPress("DrainageGate");
                    }
                }
                temp_currentWP = currentWP;
                currentWP++;
                if (currentWP >= waypoints.Length)
                {
                    currentWP = temp_currentWP;
                    if(!AfterMakeDrain)
                    {
                        AfterMakeDrain = true;
                        
                        foreach (GameObject a in afterdrainage)
                        {
                            a.GetComponent<Flood>().DetectKeyPress("AfterDrainageGate");
                        }
                    }
                }
                
            }
            
            this.transform.Translate(0, 0, speed * Time.deltaTime);

        }

        // Agent does this if user presses "C" key on the keyboard
        else if (SetWayPoints == "BadCrop")
        {

            HandleBadCrop();

            if (waypoints.Length == 0) return;
            
            Vector3 lookAtGoal = new Vector3(waypoints[currentWP].transform.position.x, this.transform.position.y, waypoints[currentWP].transform.position.z);

            Vector3 direction = lookAtGoal - this.transform.position;

            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * rotSpeed);

            
            if (direction.magnitude < accuracy)
            {

                if(currentWP == 6)
                {

                    foreach (GameObject a in crop1)
                    {
                        a.GetComponent<BadCropScript1>().DetectKeyPress("FixBadCrop");
                    }

                }
                else if(currentWP == 10)
                {
                    
                    foreach (GameObject a in crop2)
                    {
                        a.GetComponent<BadCropScript2>().DetectKeyPress("FixBadCrop");
                    }
                    
                }
                else if(currentWP == 14)
                {
                    
                    foreach (GameObject a in crop3)
                    {
                        a.GetComponent<BadCropScript3>().DetectKeyPress("FixBadCrop");
                    }
                    
                }
                else if(currentWP == 18)
                {
                    
                    foreach (GameObject a in crop4)
                    {
                        a.GetComponent<BadCropScript4>().DetectKeyPress("FixBadCrop");
                    }
                    
                }
                temp_currentWP = currentWP;
                currentWP++;
                if (currentWP >= waypoints.Length)
                {
                    currentWP = temp_currentWP;
                    // currentWP = 0;
                }
                
            }
            
            this.transform.Translate(0, 0, speed * Time.deltaTime);

        }

        // Agent does this if user presses "S" key on the keyboard
        else if (SetWayPoints == "BadSoil")
        {

            HandleBadCrop();

            if (waypoints.Length == 0) return;
            
            Vector3 lookAtGoal = new Vector3(waypoints[currentWP].transform.position.x, this.transform.position.y, waypoints[currentWP].transform.position.z);

            Vector3 direction = lookAtGoal - this.transform.position;

            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * rotSpeed);

            
            if (direction.magnitude < accuracy)
            {

                if(currentWP == 18)
                {
                    
                    foreach (GameObject a in BadSoilObject)
                    {
                        a.GetComponent<BadSoilScript>().DetectKeyPress("FixBadSoil");
                    }
                    
                }
                temp_currentWP = currentWP;
                currentWP++;
                if (currentWP >= waypoints.Length)
                {
                    currentWP = temp_currentWP;
                    // currentWP = 0;
                }
                
            }
            
            this.transform.Translate(0, 0, speed * Time.deltaTime);

        }

    }

}
