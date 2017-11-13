using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCReacTabularDala.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetEmployeeData()
        {
            using (Database1Entities dc = new Database1Entities())
            {
                var data = dc.Employees.OrderBy(a => a.FirstName).ToList();
                return new JsonResult {Data = data, JsonRequestBehavior = JsonRequestBehavior.AllowGet};
            }
        }
    }
}