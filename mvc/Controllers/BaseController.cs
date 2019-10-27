using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc.Controllers
{
    //[SessionState(System.Web.SessionState.SessionStateBehavior.Required)]
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            System.Threading.Thread.Sleep(3000);
            Session["TestVariable"] = "actualizar valor";
        }
    }
}