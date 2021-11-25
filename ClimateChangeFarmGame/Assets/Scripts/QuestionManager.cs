using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;

public class QuestionManager : MonoBehaviour
{
    public TextMeshProUGUI questionText;
    
    public Text optionA;
    public Text optionB;

    public GameObject optionAButton;
    public GameObject optionBButton;

    Question currentQuestion;

    public void choose(string optionSelected)
    {
        var nextQuestion = optionSelected == "A" ? optionA.text : optionB.text;
        currentQuestion = currentQuestion.choose(nextQuestion);

        questionText.GetComponent<TextMeshProUGUI>().text = currentQuestion.question;

        var questionAlternatives = currentQuestion.answers.Keys.ToList();
        optionA.text = questionAlternatives[0];
        optionB.text = questionAlternatives[1];
    }

    private void Start()
    {
        currentQuestion = QuestionBank.getFirstQuestion();
        questionText.GetComponent<TextMeshProUGUI>().text = currentQuestion.question;


        var questionAlternatives = currentQuestion.answers.Keys.ToList();
        optionA.text = questionAlternatives[0];
        optionB.text = questionAlternatives[1];
    }

}
