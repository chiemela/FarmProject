using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Thing : MonoBehaviour
{
    public TMP_Text UserFeedbackText;
    public TMP_Text AgentHealthText;
    public TMP_Text AgentStateText;

    // Use this for initialization
    void Start()
    {
        UserFeedbackText = GetComponent<TextMeshProUGUI>();
        AgentHealthText = GetComponent<TextMeshProUGUI>();
        AgentStateText = GetComponent<TextMeshProUGUI>();
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
        
        if(Input.GetKeyUp(KeyCode.F))
        {
            UserFeedbackText.text = "F key entered.";
        }
        
        if(Input.GetKeyUp(KeyCode.P))
        {
            UserFeedbackText.text = "P key entered.";
        }
    }

}
