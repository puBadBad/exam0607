using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace exam0607.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Music()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Music(string name, int number)
        {
            var result = "";
            if (number == 1)
            {
                result = "do";
            }
            else if (number == 2)
            {

                result = "re";
            }
            else if (number == 3)
            {
                result = "mi";
            }
            else if (number == 4)
            {

                result = "fa";
            }
            else if (number == 5)
            {
                result = "so";
            }
            else if (number == 6)
            {
                result = "la";
            }
            else if (number == 7)
            {
                result = "si";
            }
            else
            {
                result = "錯誤";
            }

            //判斷name是否為空字串
            if (!string.IsNullOrEmpty(name))
            {
                ViewBag.Result = "Hi, " + name + ", " + "查詢音符為：" + result;
            }
            return View();
        }
    }
}