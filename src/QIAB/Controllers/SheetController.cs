using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QIAB.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace QIAB.Controllers
{
    public class SheetController : Controller
    {
        private QIABContext _context;

        public SheetController(QIABContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.typeList = _context.QuestionTypes.ToList();

            Sheet sheet = new Sheet();
            sheet.FromDate = DateTime.Now.Date;
            return View(sheet);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Sheet sheet)
        {
            ViewBag.typeList = _context.QuestionTypes.ToList();
            if (ModelState.IsValid)
            {
                //                _context.Questions.Add(questionModel);
                //                _context.SaveChanges();
                //                return RedirectToAction("Index");

                //display the sheet

                ViewBag.typeList = _context.QuestionTypes.ToList();
                if (sheet.FromDate == DateTime.Now.Date)
                {

                    Random rnd = new Random();

                    IEnumerable<QuestionModel> questionSet1 =
                    _context.Questions.ToList().Where(x => x.QuestionTypeId == sheet.QuestionSet1).OrderBy(x => rnd.Next()).Take(20);
                    IEnumerable<QuestionModel> questionSet2 =
                        _context.Questions.ToList().Where(x => x.QuestionTypeId == sheet.QuestionSet2).OrderBy(x => rnd.Next()).Take(20);
                    IEnumerable<QuestionModel> questionSet3 =
                        _context.Questions.ToList().Where(x => x.QuestionTypeId == sheet.QuestionSet3).OrderBy(x => rnd.Next()).Take(20);
                    IEnumerable<QuestionModel> questionSet4 =
                        _context.Questions.ToList().Where(x => x.QuestionTypeId == sheet.QuestionSet4).OrderBy(x => rnd.Next()).Take(20);
                    ViewBag.questionSet1 = questionSet1;
                    ViewBag.questionSet2 = questionSet2;
                    ViewBag.questionSet3 = questionSet3;
                    ViewBag.questionSet4 = questionSet4;
                }
                else
                {
                    IEnumerable<QuestionModel> questionSet1 =
                        _context.Questions.ToList().Where(x => x.QuestionTypeId == sheet.QuestionSet1 && x.DateEntered <= sheet.FromDate).Take(4);
                    IEnumerable<QuestionModel> questionSet2 =
                        _context.Questions.ToList().Where(x => x.QuestionTypeId == sheet.QuestionSet2 && x.DateEntered <= sheet.FromDate).Take(4);
                    IEnumerable<QuestionModel> questionSet3 =
                        _context.Questions.ToList().Where(x => x.QuestionTypeId == sheet.QuestionSet3 && x.DateEntered <= sheet.FromDate).Take(4);
                    IEnumerable<QuestionModel> questionSet4 =
                        _context.Questions.ToList().Where(x => x.QuestionTypeId == sheet.QuestionSet4 && x.DateEntered <= sheet.FromDate).Take(4);

                    ViewBag.questionSet1 = questionSet1;
                    ViewBag.questionSet2 = questionSet2;
                    ViewBag.questionSet3 = questionSet3;
                    ViewBag.questionSet4 = questionSet4;
                }

            }
            return View(sheet);
        }
    }
}

