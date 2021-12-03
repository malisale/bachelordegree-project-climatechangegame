using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class QuestionBank
{
    public static Question startQuestion;

    public static Question GetFirstQuestion()
    {
        if (startQuestion != null)
        {
            return startQuestion;
        }

        var startQuestionAlternatives = new Dictionary<string, Question>();
        var minecraftQuestionAlternatives = new Dictionary<string, Question>();
        var lotrQuestionAlternatives = new Dictionary<string, Question>();
        var subQuestionAlternatives = new Dictionary<string, Question>();


        var subQuestion = new Question("How many letters is there in the word Steve?", subQuestionAlternatives);
        subQuestionAlternatives.Add("5", null);
        subQuestionAlternatives.Add("4", null);

        minecraftQuestionAlternatives.Add("Samuel", null);
        minecraftQuestionAlternatives.Add("Steve", subQuestion);
        var minecraftQuestion = new Question("What is the protagonist in minecraft called?", minecraftQuestionAlternatives);

        lotrQuestionAlternatives.Add("J.R Tolkien", null);
        lotrQuestionAlternatives.Add("Principal of Hogwarts", null);
        var lotrQuestion = new Question("Who wrote LOTR?", lotrQuestionAlternatives);

        startQuestionAlternatives.Add("Minecraft launched", minecraftQuestion);
        startQuestionAlternatives.Add("Lord of the Rings remake", lotrQuestion);

        startQuestion = new Question("What happened in 2011", startQuestionAlternatives);

        return startQuestion;
    }
}


