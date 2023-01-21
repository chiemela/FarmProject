using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WayPointHarvestCrop : MonoBehaviour
{
    public GameObject[] waypoints;
    int currentWP = 0;
    int temp_currentWP =  0;
    float speed = 4.0f;
    float accuracy = 1.0f;
    float rotSpeed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        waypoints = GameObject.FindGameObjectsWithTag("Crop");
    }

    // LateUpdate is called once per frame
    void LateUpdate()
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
