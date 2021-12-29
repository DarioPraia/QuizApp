using Quiz.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Data
{
    public class InMemoryQuestionData : IQuestionData
    {
        private readonly List<Question> questions;

        public InMemoryQuestionData()
        {
            this.questions = new List<Question>()
            {
                new Question() { 
                    Id = 1, 
                    Name = "Qual é a capital de Angola?", 
                    Answers = new List<Answer>()
                    {
                        new Answer() { Id = 1, Name = "Benguela" },
                        new Answer() { Id = 2, Name = "Angola" },
                        new Answer() { Id = 3, Name = "Huambo" },
                        new Answer() { Id = 4, Name = "Uíge" }
                    },
                    AnswerCorrectId = 1
                }
            };
        }

        public Question GetQuestionById(int id)
        {
            return questions.Find(q => q.Id == id);
        }
    }
}
