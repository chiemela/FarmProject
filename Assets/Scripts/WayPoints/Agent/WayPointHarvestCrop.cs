using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WayPointHarvestCrop : MonoBehaviour
{
    public GameObject[] waypoints;
    int currentWP = 0;
    int temp_currentWP =  0;
    float speed = 4.0f;
    float accuracy = 1.0f;
    float rotSpeed = 3.0f;
    string SetWayPoints = "";

    // Start is called before the first frame update
    void Start()
    {
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

    }

}
