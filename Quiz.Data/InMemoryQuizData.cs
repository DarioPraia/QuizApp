using Quiz.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Data
{
    public class InMemoryQuizData : IQuizData
    {
        private readonly List<Quizz> quizzs; 

        public InMemoryQuizData()
        {
            this.quizzs = new List<Quizz>()
            {
                new Quizz()
                {
                    Id = 1,
                    Questions = new List<Question>()
                }
            };
        }

        public Quizz AddQuestions(int id, List<Question> questions)
        {
            Quizz quizz = quizzs.Find(q => q.Id == id);

            quizz.Questions = questions;

            return quizz;
        }

        public Quizz EndQuizz(int id)
        {
            Quizz quizz = quizzs.Find(q => q.Id == id);

            quizz.EndDate = DateTime.Now;

            return quizz;
        }

        public Question GetQuizQuestionById(int quizId, int questionId)
        {
            return quizzs.Find(q => q.Id == quizId).Questions.Find(q => q.Id == questionId);
        }

        public Quizz GetQuizzById(int id)
        {
            return quizzs.Find(q => q.Id == id);
        }

        public Quizz StartQuizz(int id)
        {
            Quizz quizz = quizzs.Find(q => q.Id == id);

            quizz.StartDate = DateTime.Now;

            return quizz;
        }

        public Quizz UpdateQuestion(int id, Question question)
        {
            Quizz quizz = quizzs.Find(q => q.Id == id);

            Question questionToUpdate = quizz.Questions.Find(q => q.Id == question.Id);

            questionToUpdate.UserAnswerId = question.UserAnswerId;

            return quizz;
        }
    }
}
