using Microsoft.AspNetCore.Mvc;
using Survey.Data;
using Survey.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Survey.Models; // Update with the correct namespace

public class QuestionnaireController : Controller
{
    private readonly ApplicationContext _context;

    public QuestionnaireController(ApplicationContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var questionnaire = _context.Questionnaires
            .Include(q => q.Questions)
            .ThenInclude(q => q.Answers)
            .FirstOrDefault();

        return View(questionnaire);
    }

    [HttpPost]
    public IActionResult SubmitAnswers(List<int> selectedAnswers)
    {
        // Process selected answers and save them to the database
        var userResponses = selectedAnswers.Select(answerId => new UserResponse { AnswerId = answerId }).ToList();

        _context.UserResponses.AddRange(userResponses);
        _context.SaveChanges();

        // Calculate the result if needed

        // Pass the questionnaire and selected answers to the Result view
        var resultData = new Tuple<Questionnaire, List<int>>(_context.Questionnaires.FirstOrDefault(), selectedAnswers);
        return View("Result", resultData);
    }
}
