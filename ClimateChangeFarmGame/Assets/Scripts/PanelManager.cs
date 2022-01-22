using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{
    
    
    
    private string prompt; 
    private string[] answers; 
    private int[] nextQuestion; 
    
    public TextMeshProUGUI questionText;
    public Text optionAText;
    public Text optionBText;
    public Text optionCText;

    private QuestionManager _questionManager;
    
    public void SetData(string prompt, string[] answers, int[] nextQ, QuestionManager questionManager)
    {
        this.prompt = prompt;
        this.answers = answers;
        this.nextQuestion = nextQ;
        this._questionManager = questionManager;

        questionText.text = prompt;
        optionAText.text = answers[0];
        optionBText.text = answers[1];
        
        //TODO check for questions if 2 or 3 answers
        // TODO get children, hide or enable third button
        //if()
    }
    
    
    
    
    public void ClickA()
    {
        GameObject nextQuestion = _questionManager.GiveMeNextQuestion(this.nextQuestion[0]);
        SwitchQuestion(nextQuestion);

    }
   
    public void ClickB()
    {
        Debug.Log("clicked B");

        //SwitchQuestion(nextQuestionB);
        // SwitchEnvironment(nextEnvironmentC);
        //Destroy(this.gameObject);

    }
    public void ClickC()
    {
        Debug.Log("clicked C");

        //SwitchQuestion(nextQuestionC);
        // SwitchEnvironment(nextEnvironmentC);
        //Destroy(this.gameObject);

    }
    
    public void SwitchQuestion(GameObject question)
    {
        
        question.SetActive(true);
        this.gameObject.SetActive(false);
        Destroy(this.gameObject);

    }
    
   

    
}
