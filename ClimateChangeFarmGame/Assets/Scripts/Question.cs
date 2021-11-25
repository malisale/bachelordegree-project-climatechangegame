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

    public Question choose(string choice)
    {
        return answers[choice];
    }




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
