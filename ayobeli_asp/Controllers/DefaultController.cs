using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ayobeli_asp.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
												ViewBag.BrowserWidth = Request.Browser.ScreenPixelsWidth;
												return View();
        }

								public ActionResult Error(int id)
								{
												ViewBag.ErrorCode = id == 502 ? id : 404;
												ViewBag.Message = id == 502 ? StringResource.ErrorBadGateway : StringResource.ErrorPageNotFound;
												return View();
								}
    }
}