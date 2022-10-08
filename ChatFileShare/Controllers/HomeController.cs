using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChatFileShare.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ChatGroup()
        {
            return View();
        }
        public ActionResult UploadFile()
        {
            object result = null;
            var files = Request.Files;
            if (files != null && files.Count > 0)
            {
                var file = files[0];
                var filePath = Server.MapPath("~/MyFiles/" + file.FileName);
                file.SaveAs(filePath);
                result = new { message = "file saved successfully." };
            }
            return Json(result);
        }
    }
}