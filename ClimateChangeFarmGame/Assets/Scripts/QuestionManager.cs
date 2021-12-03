using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuestionManager : MonoBehaviour
{
   
    public TextMeshProUGUI questionText;
    public Text optionAText;
    public Text optionBText;
    
    // Use this vars if I want to add text in inspector
    
    /*public string question;
    public string optionA;
    public string optionB;*/

    public GameObject nextQuestionA;
    public GameObject nextQuestionB;
   
    // Use this if I want to add text in inspector
    /*private void Start()
    {   
        questionText.text = question;
        optionAText.text = optionA;
        optionBText.text = optionB;
    }*/

    
    public void SwitchQuestion(GameObject q)
    {
        q.SetActive(true);
        this.gameObject.SetActive(false);
        Destroy(this.gameObject);
    }

    public void ClickA()
    {
        Debug.Log("clicked A");
        
        //DO SOMETHING 
        //ANIMATION
        //SOUND
        //MOVE CAMERA
        //DELAY 
        //CAMERA MANAGER. DO SOMETHING---> SWITCH THE QUESTION
        
        SwitchQuestion(nextQuestionA);
        //wait here 30 secs
    }
    
    public void ClickB()
    {
        Debug.Log("clicked B");
        
        SwitchQuestion(nextQuestionB);
    }
    
    // TODO create ClickC() method and assign to button C in some questions
    
    private void OnEnable()
    {
        if(Camera.main != null)
            Camera.main.GetComponent<CameraController>().IsCameraActive(false);
    }
    
    // Check where to add later
    /*private void OnDisable()
    {        
        Camera.main.GetComponent<CameraController>().activeCamera(true);
    }*/
}