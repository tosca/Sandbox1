using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sandbox.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

       public ActionResult Index()
        {
            return View();
       }
        public ActionResult Scribbles()
        {

            return View();
        }
        public ActionResult KidsRings()
        {

            return View();
        }
        public ActionResult TheMotherLoadProject()
        {

            return View();
        }
        public ActionResult About()
        {

            return View();
        }
        public ActionResult Contact()
        {

            return View();
        }
     }   
        
     
    
}
