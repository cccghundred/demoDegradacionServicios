using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace mvc.Controllers
{
    //[SessionState(System.Web.SessionState.SessionStateBehavior.Required)]
    public class HomeController : BaseController
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

        [HttpGet]
        public async Task<JsonResult> accion1()
        {
            System.Threading.Thread.Sleep(3000);
            return Json(new { esteLibroEstaPrestado = false }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public async Task<JsonResult> accion2()
        {
            System.Threading.Thread.Sleep(3000);
            return Json(new { esteLibroEstaPrestado = false }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public async Task<JsonResult> accion3()
        {
            System.Threading.Thread.Sleep(3000);
            return Json(new { esteLibroEstaPrestado = false }, JsonRequestBehavior.AllowGet);
        }
    }
}