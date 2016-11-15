using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QIAB.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace QIAB.Controllers
{
    public class TypeController : Controller
    {
        private QIABContext _context;

        public TypeController(QIABContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.QuestionTypes.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(QuestionType questionType)
        {
            if (ModelState.IsValid)
            {
                _context.QuestionTypes.Add(questionType);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(questionType);
        }
    }
}
