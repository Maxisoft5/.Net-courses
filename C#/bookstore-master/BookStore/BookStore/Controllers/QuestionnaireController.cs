using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    public class QuestionnaireController : Controller
    {
        // GET: Questionnaire
        public ActionResult Index()
        {
            ViewBag.Questions = new List<String> { "How many unreading books do you have in your library?", "Do you rereading your books?", "How many books do you read per month?" };
            return View(ViewBag.Questions);
        }

        [HttpPost]
        public ActionResult GiveAnswers(string option1, string option2, string option3)
        {
            int junior = 0;
            int middle = 0;
            int senior = 0;
            string result = "";
            if (option1 == "10-20" || option2 == "Yes" || option3 == "3-4")
            {
                senior++;
            }
            if (option1 == "5-6" || option3 == "1-2")
            {
                middle++;
            }
            if (option1 == "1-2" || option2 == "No" || option3 == "0")
            {
                junior++;
            }
            if (junior > middle && junior > senior)
            {
                result = "Junior Reader";
            }
            if (middle > junior && middle > senior)
            {
                result = "Middle Reader";
            }
            if (senior > middle && senior > junior)
            {
                result = "Senior Reader";
            }
            ViewBag.Result = result;
            return View(ViewBag.Result);
        }
        [HttpGet]
        public ActionResult GiveAnswers()
        {
            return View();
        }
    }
}