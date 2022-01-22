using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class QData
{
    //public string[] questions;
    //public string[] answers;
    public int questionNumber;
    public string prompt;
    public string[] answers;
    public int[] nextQuestion;


    public QData()
    {
        
    }

    public QData(int questionNumber, string prompt, string[] answers, int[] nextQuestion)
    {
        this.questionNumber = questionNumber;
        this.prompt = prompt;
        this.answers = answers;
        this.nextQuestion = nextQuestion;
    }
}
