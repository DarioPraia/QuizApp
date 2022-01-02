using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Core
{
    public class Question
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Answer> Answers { get; set; }

        public int AnswerCorrectId { get; set; }

        public int UserAnswerId { get; set; }
    }
}
