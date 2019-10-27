using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace mvc.Controllers
{
    //[SessionState(System.Web.SessionState.SessionStateBehavior.ReadOnly)]
    public class Controlador2Controller : BaseController
    {
        // GET: Controlador2
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<JsonResult> accion3()
        {
            System.Threading.Thread.Sleep(5000);

            return Json(new { esteLibroEstaPrestado = false }, JsonRequestBehavior.AllowGet);
        }
    }
}