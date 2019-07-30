using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoSearchCLMVC.Factory;
using ToDoSearchCLMVC.Models;
using ToDoSearchCLMVC.Repository;

namespace ToDoSearchCLMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SearchTown(string term)
        {
            SearchTownFactory searchTownFac = new SearchTownFactory();
            var town = searchTownFac.SearchTown(term);

            return this.Json(town, JsonRequestBehavior.AllowGet);

        }

   


    }
}
