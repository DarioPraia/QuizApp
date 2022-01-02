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
    public class ShowModel : PageModel
    {
        private IQuestionData questionData;

        [BindProperty]
        public Question Question { get; set; } 

        [BindProperty]
        public int answerId { get; set; }

        /*  -----   */
        private IQuizData quizData;

        public Quizz Quizz { get; set; }

        public ShowModel(IQuestionData questionData, IQuizData quizData)
        {
            this.questionData = questionData;

            this.quizData = quizData;
            this.quizData.AddQuestions(1, this.questionData.GetAll());
        }

        public void OnGet(int id)
        {
            //Question = questionData.GetQuestionById(id); 
            Question = quizData.GetQuizQuestionById(1, id);

            if (quizData.GetQuizzById(1).StartDate == null)
            {
                quizData.StartQuizz(1);
            }
        }

        public IActionResult OnPost()
        {
            Quizz = quizData.UpdateQuestion(1, Question);

            int nextQuestionId = Question.Id + 1;

            Question = quizData.GetQuizQuestionById(1, nextQuestionId);

            if (Question == null)
            {
                quizData.EndQuizz(Quizz.Id);

                return RedirectToPage("./Result");
            } 

            return RedirectToPage(new { id = nextQuestionId});
        }
    }
}
