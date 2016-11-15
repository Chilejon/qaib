using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QIAB.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace QIAB.Controllers
{
    public class QuestionController : Controller
    {
        private QIABContext _context;

        public QuestionController(QIABContext context)
        {
            _context = context;
        }

        public IActionResult Index(string Id)
        {
            ViewBag.typeList = _context.QuestionTypes.ToList();
            if (!string.IsNullOrEmpty(Id))
            {
                return View(_context.Questions.ToList().Where(x => x.QuestionTypeId == Id));
            }

            return View(_context.Questions.ToList());
        }

        public IActionResult Create()
        {
            ViewBag.typeList = _context.QuestionTypes.ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(QuestionModel questionModel)
        {
            if (ModelState.IsValid)
            {
                _context.Questions.Add(questionModel);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(questionModel);
        }

        public IActionResult Edit(Guid id)
        {
            var question = _context.Questions.FirstOrDefault(x => x.Id == id);
            ViewBag.typeList = _context.QuestionTypes.ToList();
            return View(question);
            }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(QuestionModel questionModel)
        {
            if (ModelState.IsValid)
            {
                QuestionModel contextquestionModel = _context.Questions.FirstOrDefault(x => x.Id == questionModel.Id);

                contextquestionModel.Question = questionModel.Question;
                contextquestionModel.PotAnswer1 = questionModel.PotAnswer1;
                contextquestionModel.PotAnswer2 = questionModel.PotAnswer2;
                contextquestionModel.PotAnswer3 = questionModel.PotAnswer3;
                contextquestionModel.Answer = questionModel.Answer;
                contextquestionModel.QuestionTypeId = questionModel.QuestionTypeId;
                
                _context.SaveChanges();
                return RedirectToAction("Index", "Question");
            }

            return View(questionModel);
        }


    }
}
