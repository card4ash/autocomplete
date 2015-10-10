using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using autocomplete.Models;

namespace autocomplete.Controllers
{
    public class HomeController : Controller
    {
        autocomplete.DataAccess.PollidutEntities db = new DataAccess.PollidutEntities();
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult FetchTagList(string tag)
        {
            var tags = db.EMPLOYEES.Where(e => e.EMPLOYEE_TYPE_ID == 2 && e.PERSON.PERSON_NAME.Contains(tag)).Select(e => new Tag
            {
                ID = e.EMPLOYEE_ID,
                TagName = e.PERSON.PERSON_NAME
            }).ToList();
            return Json(new { status="success",data=tags});
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}