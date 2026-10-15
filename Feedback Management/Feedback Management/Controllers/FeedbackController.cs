
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using FeedbackManagement.Models;

namespace FeedbackManagement.Controllers
{
    public class FeedbackController : Controller
    {
        // Temporary in-memory storage for this practical
        private static readonly List<Feedback> feedbackList =
            new List<Feedback>();

        private static int nextId = 1;

        public ActionResult Index()
        {
            return View(feedbackList);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new Feedback());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                feedback.Id = nextId++;
                feedback.SubmittedOn = DateTime.Now;

                feedbackList.Add(feedback);

                TempData["Message"] =
                    "Thank you! Your feedback was submitted successfully.";

                return RedirectToAction("Index");
            }

            return View(feedback);
        }
    }
}
