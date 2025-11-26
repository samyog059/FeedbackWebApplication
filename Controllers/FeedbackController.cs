using Microsoft.AspNetCore.Mvc;
using FeedbackWebApplication.Data;
using FeedbackWebApplication.Models;

namespace FeedbackWebApplication.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly AppDbContext _context;

        public FeedbackController(AppDbContext context)
        {
            _context = context;
        }

        // Show feedback form
        public IActionResult Create()
        {
            return View();
        }

        // Save feedback to database
        [HttpPost]
        public IActionResult Create(feedback model)
        {
            if (ModelState.IsValid)
            {
                _context.feedbacks.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Success");
            }

            return View(model);
        }

        // After successful submission
        public IActionResult Success()
        {
            return View();
        }

        // List all feedbacks
        public IActionResult List()
        {
            var data = _context.feedbacks.ToList();
            return View(data);
        }
    }
}
