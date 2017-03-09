using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.JavaScript;
using Syncfusion.JavaScript.Models;
namespace SFSample
{
    public partial class CaptchaController : Controller
    {
        //
        // GET: /Captcha/
        public ActionResult CaptchaFeatures()
        {
            return View();
        }
        public ActionResult Refresh(CaptchaParams parameters)
        {
            return parameters.CaptchaActions();
        }
    }
}
