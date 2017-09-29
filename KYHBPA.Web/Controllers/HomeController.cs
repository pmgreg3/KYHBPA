using KYHBPA.Data.Interfaces;
using KYHBPA.Data.Repositories;
using KYHBPA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KYHBPA.Web.Controllers
{
    public class HomeController : Controller
    {
        private IGenericRepository<Image> _ImageRepo;

        public HomeController(IGenericRepository<Image> imageRepo)
        {
            _ImageRepo = imageRepo;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}