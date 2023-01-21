using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WriteToScreen : MonoBehaviour
{
    public TMP_Text UserFeedbackText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.S))
        {
            UserFeedbackText.text = "S key entered.";
        }
        
        if(Input.GetKeyUp(KeyCode.C))
        {
            UserFeedbackText.text = "C key entered.";
        }
        
        if(Input.GetKeyUp(KeyCode.W))
        {
            UserFeedbackText.text = "W key entered.";
        }
        
        if(Input.GetKeyUp(KeyCode.P))
        {
            UserFeedbackText.text = "P key entered.";
        }
    }
}
