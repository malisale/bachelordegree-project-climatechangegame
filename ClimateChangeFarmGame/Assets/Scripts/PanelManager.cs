using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{
    //private GameObject _questionPrefab;
    
    private string _prompt; 
    private string[] _answers; 
    private int[] _nextQuestion; 
    
    public TextMeshProUGUI questionText;
    public Text optionAText;
    public Text optionBText;
    public Text optionCText;

    private QuestionManager _questionManager;

    public void SetData(string prompt, string[] answers, int[] nextQ, QuestionManager questionManager)
    {
        this._prompt = prompt;
        this._answers = answers;
        this._nextQuestion = nextQ;
        this._questionManager = questionManager;

        questionText.text = prompt;
        optionAText.text = answers[0];
        optionBText.text = answers[1];

        //TODO check for questions if 2 or 3 answers
        // TODO get children, hide or enable third button
        if (answers.Length == 3)
        {
            optionAText.text = _answers[0];
            optionBText.text = _answers[1];
            optionCText.text = _answers[2];
        }
        else
        {
            this.gameObject.transform.GetChild(3).gameObject.SetActive(false);
            //_questionPrefab.transform.Find("OptionC").gameObject.SetActive(false);
        }
    }

    public void ClickA()
    {
        Debug.Log("You clicked  Answer A!");
        var nextQuestion = _questionManager.GiveMeNextQuestion(this._nextQuestion[0]);
        SwitchQuestion(nextQuestion);

    }
   
    public void ClickB()
    {
        Debug.Log("You clicked  Answer B!");
        var nextQuestion = _questionManager.GiveMeNextQuestion(this._nextQuestion[1]);
        SwitchQuestion((nextQuestion));
    }
    public void ClickC()
    {
        Debug.Log("You clicked  Answer C!");
        var nextQuestion = _questionManager.GiveMeNextQuestion(this._nextQuestion[2]);
        SwitchQuestion(nextQuestion);
    }
    
    public void SwitchQuestion(GameObject question)
    {
        
        question.SetActive(true);
        this.gameObject.SetActive(false);
        Destroy(this.gameObject);

    }
    
   

    
}
