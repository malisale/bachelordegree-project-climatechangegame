using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using Newtonsoft.Json;

public class QuestionManager : MonoBehaviour
{
    
    public TextMeshProUGUI questionText;
    public Text optionAText;
    public Text optionBText;

    // Question data read from JSON
    //private Question[] questions;

    // Use this vars if I want to add text in inspector

    /*public string question;
    public string optionA;
    public string optionB;*/

    public GameObject nextQuestionA;
    public GameObject nextQuestionB;
    public GameObject nextQuestionC;

    /*public GameObject nextEnvironmentA;
    public GameObject nextEnvironmentB;
    public GameObject nextEnvironmentC;
    */

    public List<QData> questions;

    private List<GameObject> panels;

    public GameObject panelPrefab;


    // Use this if I want to add text in inspector
    private void Start()
    {
        /*questionText.text = question;
        optionAText.text = optionA;
        optionBText.text = optionB;*/
        
        //string path = Application.dataPath + "/test.json";
        string jsonString = File.ReadAllText("Assets/Data/test.json");

        questions = JsonConvert.DeserializeObject<List<QData>>(jsonString);
        
        Debug.Log(questions[0].prompt);
        Debug.Log(questions[0].answers[0]);
        
         // TODO NEED TO SET DATA! question[0]
        // panel.GetComponent<PanelManager>().SetData();
       
       
        
        
        
    }

    //public IEnumerator<WaitForSeconds> SwitchQuestion(GameObject question)
    //{   
    //    yield return new WaitForSeconds(5);
    //    question.SetActive(true);
    //    this.gameObject.SetActive(false);
    //    Destroy(this.gameObject);

    //}
    // public void SwitchQuestion(GameObject question)
    // {
    //     // string path = "Assets/Data/questions/json";
    //     // string jsonString = File.ReadAllText(path);
    //     // jsonString = jsonString.Replace("\r\n", "");
    //     // object questionData = JsonConvert.DeserializeObject(jsonString);
    //     
    //
    //     // STEP 1 : you now have a list of all question objects.
    //     // The type you get back is "object[]", however you want
    //     // go have a "Question[]" object. So you cast it to
    //     // an "Question[]".
    //
    //     // STEP 2 : Loop over all the question objects in the array.
    //     // "answers" is a list of lists. "answers[0][1] will get back
    //     // the question index which answer A leads to
    //
    //     // "answers" => [][]
    //     // "answers[0] => ["open type", 2]
    //     // "answers[0][1] => 2
    //
    //     question.SetActive(true);
    //     this.gameObject.SetActive(false);
    //     Destroy(this.gameObject);
    //
    // }
    //
    // // public void SwitchEnvironment(GameObject environment)
    // // {
    // //     environment.SetActive(true);
    // //     FindObjectOfType<EnvironmentController>().gameObject.SetActive(false);
    // //     
    // //    
    // // }
    // public void ClickA()
    // {
    //     Debug.Log("clicked A");
    //
    //     //DO SOMETHING 
    //     //ANIMATION
    //     //SOUND
    //     //MOVE CAMERA
    //     //DELAY 
    //     //CAMERA MANAGER. DO SOMETHING---> SWITCH THE QUESTION
    //     // SwitchEnvironment(nextEnvironmentA);
    //
    //     //SwitchQuestion(nextQuestionA);
    //     //wait here 30 secs
    //
    //     //Destroy(this.gameObject);
    //     //StartCoroutine(SwitchQuestion(nextQuestionA));
    //     SwitchQuestion(nextQuestionA);
    //
    //     // StartCoroutine(TransitionManager.ChangeQuestion(nextQuestionA));
    //     // this.gameObject.SetActive(false);
    //     // Destroy(this.gameObject);
    // }
    //
    // public void ClickB()
    // {
    //     Debug.Log("clicked B");
    //     //  SwitchEnvironment(nextEnvironmentB);
    //     SwitchQuestion(nextQuestionB);
    //     //Destroy(this.gameObject);
    //
    // }
    //
    // public void ClickC()
    // {
    //     Debug.Log("clicked C");
    //
    //     SwitchQuestion(nextQuestionC);
    //     // SwitchEnvironment(nextEnvironmentC);
    //     //Destroy(this.gameObject);
    //
    // }



    private void OnEnable()
    {
        if (Camera.main != null)
            Camera.main.GetComponent<CameraController>().IsCameraActive(false);
    }

    // Check where to add later
    /*private void OnDisable()
    {        
        Camera.main.GetComponent<CameraController>().IsCameraActive(true);
    }*/
    
    
    
    public GameObject GiveMeNextQuestion(int i)
    {
        //TODO NEED TO SET DATA! question[index - 1]
        
        GameObject panel = Instantiate(panelPrefab);
        panels.Add(panel);
        panel.GetComponent<PanelManager>().SetData();
        
        return panels[i - 1];
    }
}