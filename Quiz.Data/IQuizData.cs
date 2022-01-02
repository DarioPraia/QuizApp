using Quiz.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Data
{
    public interface IQuizData
    {
        Quizz GetQuizzById(int id);
        //Quizz AddQuizQuestion(int quizId, Question question);
        Quizz StartQuizz(int id);
        Quizz EndQuizz(int id);
        Quizz AddQuestions(int id, List<Question> questions);
        Quizz UpdateQuestion(int id, Question question);
        Question GetQuizQuestionById(int quizId, int questionId);
    }
}
