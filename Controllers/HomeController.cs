using Practice.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice.Controllers
{[Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        public ActionResult ContactForm()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ContactForm(MemberModel membervalues)
        {
            //Use Namespace called :  System.IO  
            //string FileName = Path.GetFileNameWithoutExtension(membervalues.ImageFile.FileName);
           
            //To Get File Extension  
            //string FileExtension = Path.GetExtension(membervalues.ImageFile.FileName);
            string File = Path.GetFileName(membervalues.ImageFile.FileName);
            //Add Current Date To Attached File Name  
            //FileName = DateTime.Now.ToString("yyyyMMdd") + "-" + FileName.Trim() + FileExtension;

            //Get Upload path from Web.Config file AppSettings.  
            //string UploadPath = ConfigurationManager.AppSettings["userimage"].ToString();
            string UploadPath = Server.MapPath("~/userimage/");
            //Its Create complete path to store in server.  
            membervalues.ImagePath = UploadPath + File;

            //To copy and save file into server.  
            membervalues.ImageFile.SaveAs(membervalues.ImagePath);
            string saveDbString = "/userimage/"+File;
            return View();
        }
    }
}