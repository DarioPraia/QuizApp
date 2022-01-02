using Quiz.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Data
{
    public interface IQuestionData
    {
        Question GetQuestionById(int id);
        List<Question> GetAll();
    }
}
