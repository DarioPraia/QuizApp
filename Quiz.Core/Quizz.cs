using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Core
{
    public class Quizz
    {
        public int Id { get; set; }
        public List<Question> Questions { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
