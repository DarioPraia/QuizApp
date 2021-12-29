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

        public ShowModel(IQuestionData questionData)
        {
            this.questionData = questionData;
        }

        public void OnGet(int id)
        {
            Question = questionData.GetQuestionById(id);
        }

        public IActionResult OnPost()
        {
            int nextQuestionId = Question.Id + 1;

            Question = questionData.GetQuestionById(nextQuestionId);

            if (Question == null)
            {
                return RedirectToPage("./Result");
            }

            return RedirectToPage(new { id = nextQuestionId});
        }
    }
}
