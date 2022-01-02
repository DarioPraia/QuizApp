using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Quiz.Core;
using Quiz.Data;

namespace Quiz.Pages.Questions
{
    public class ResultModel : PageModel
    {
        private readonly IQuizData quizData;

        [TempData]
        public string Status { get; set; }

        public Quizz Quiz { get; set; }

        public int Score { get; set; }

        public string Tempo { get; set; }

        public ResultModel(IQuizData quizData)
        {
            this.quizData = quizData;
        }

        public void OnGet()
        {
            Quiz = quizData.GetQuizzById(1);

            Tempo = (Quiz.EndDate - Quiz.StartDate).TotalSeconds.ToString();

            Score = 0;

            foreach (Question question in Quiz.Questions)
            {
                if (question.AnswerCorrectId == question.UserAnswerId)
                {
                    Score += 1;
                }
            }

            TempData["Status"] = "Passed";
        }
    }
}
