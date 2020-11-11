//##########################################################
//#     ___         __                                     #
//#    /   |  _____/ /_  ______                            #
//#   / /| | / ___/ / / / / __ \                           #
//#  / ___ |(__  ) / /_/ / / / /                           # 
//# /_/  |_/____/_/\__,_/_/ /_/                            #
//#                                                        #
//# Développeur multi-platerformes                         #
//# Twitter : https://twitter.com/b_languedoc              #
//##########################################################


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Efredia.Controllers
{
    public class ServicesController : Controller
    {
   
        // GET: Services
        public ActionResult Index()
        {
            return View();
        }

        [Route("Successful")]
        // GET: Services
        public ActionResult Finish()
        {
            return View();
        }
    }
}