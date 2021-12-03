using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question
{
    public Dictionary<string, Question> answers;
    public string question;

    public Question(string question, Dictionary<string, Question> linkedQuestions)
    {
        answers = linkedQuestions;
        this.question = question;
    }

    public Question Choose(string choice)
    {
        return answers[choice];
    }
    
}
