using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using Newtonsoft.Json;

public class QuestionManager : MonoBehaviour
{
    
    private List<QData> _questions;

    private List<GameObject> _panels;

    public GameObject panelPrefab;

    public Transform parentCanvas;
   
    
    private void Start()
    {
       
        var jsonFile = File.ReadAllText("Assets/Data/questions.json");

        _questions = JsonConvert.DeserializeObject<List<QData>>(jsonFile);
        
        _panels = new List<GameObject>();
        
        var childPrefab = Instantiate(panelPrefab, parentCanvas);
        
        _panels.Add(childPrefab);
        
        // Set first question panel at start
        childPrefab.GetComponent<PanelManager>().SetData(_questions[0].prompt,_questions[0].answers, _questions[0].nextQuestion,this);



    }
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
    
    
    
    public GameObject GiveMeNextQuestion(int nextQuestionIndex)
    {
        var questionPanel = Instantiate(panelPrefab, parentCanvas);
        
        _panels.Add(questionPanel);
        
        questionPanel.GetComponent<PanelManager>().SetData(_questions[nextQuestionIndex - 1].prompt, _questions[nextQuestionIndex - 1].answers,_questions[nextQuestionIndex - 1].nextQuestion,this);
       
        return _panels[_panels.Count - 1];
        //return panel
    }
}