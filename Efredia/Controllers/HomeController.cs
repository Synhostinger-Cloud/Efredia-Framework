
//#########################################################
//#     ___         __                                     #
//#    /   |  _____/ /_  ______                            #
//#   / /| | / ___/ / / / / __ \                           #
//#  / ___ |(__  ) / /_/ / / / /                           #
//# /_/  |_/____/_/\__,_/_/ /_/                            #
//#                                                        #
//# Développeur multi-platerformes                         #
//# Twitter : https://twitter.com/aslunFR                  #
//##########################################################

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Resources;
using Efredia.Cors;

namespace Efredia.Controllers
{

 
    
    public class HomeController : Controller
    {
        [AllowCrossSite]

        // GET: Default
        public ActionResult Index()
        {
            Response.AppendHeader("Access-Control-Allow-Origin", "*");

            //Metaname
            ViewBag.description = "AslunFR est une développeur C# depuis 2017.";

            //Title
            ViewBag.Title = "Accueil";

            //Page
            ViewBag.slidertitle = "AslunFR";
            ViewBag.slidertext = "AslunFR est une développeur C# depuis 2017";

            ViewBag.indepedanttitle = "AslunFR";
            ViewBag.indepedant = "AslunFR est une développeur C# depuis 2017";

            ViewBag.col1title = "AslunFR";
            ViewBag.col1text = "AslunFR est une développeur C# depuis 2017.";

            ViewBag.col2title = "AslunFR";
            ViewBag.col2text = "AslunFR est une développeur C# depuis 2017.";

            ViewBag.col3title = "AslunFR";
            ViewBag.col3text = "AslunFR est une développeur C# depuis 2017.";

            ViewBag.col4title = "AslunFR";
            ViewBag.col4text = "AslunFR est une développeur C# depuis 2017.";

            ViewBag.activatemenu = "active";

            ViewBag.email = "contact@aslun.fr";

            return View();
        }


        [Route("404")]
        // GET: Default
        public ActionResult Error()
        {
            //Metaname
            ViewBag.description = "AslunFR est une développeur C# depuis 2017.";

            //Title
            ViewBag.Title = "404";

            //Page
            ViewBag.slidertitle = "Erreur 404";
            ViewBag.slidertext = "AslunFR est une développeur C# depuis 2017";

            ViewBag.indepedanttitle = "AslunFR";
            ViewBag.indepedant = "AslunFR est une développeur C# depuis 2017";

            ViewBag.col1title = "AslunFR";
            ViewBag.col1text = "AslunFR est une développeur C# depuis 2017.";

            ViewBag.col2title = "AslunFR";
            ViewBag.col2text = "AslunFR est une développeur C# depuis 2017.";

            ViewBag.col3title = "AslunFR";
            ViewBag.col3text = "AslunFR est une développeur C# depuis 2017.";

            ViewBag.col4title = "AslunFR";
            ViewBag.col4text = "AslunFR est une développeur C# depuis 2017.";

            ViewBag.activatemenu = "active";

            ViewBag.email = "contact@aslun.fr";
            return View();

        }

        [Route("About")]
        // GET: Default
        public ActionResult About()
        {
            //Metaname
            ViewBag.description = "AslunFR est une développeur C# depuis 2017.";

            //Title
            ViewBag.Title = "About";

            //Page
            ViewBag.slidertitle = "AslunFR";
            ViewBag.slidertext = "AslunFR est une développeur C# depuis 2017";

            ViewBag.indepedanttitle = "AslunFR";
            ViewBag.indepedant = "AslunFR est une développeur C# depuis 2017";

            ViewBag.col1title = "AslunFR";
            ViewBag.col1text = "AslunFR est une développeur C# depuis 2017.";

            ViewBag.col2title = "AslunFR";
            ViewBag.col2text = "AslunFR est une développeur C# depuis 2017.";

            ViewBag.col3title = "AslunFR";
            ViewBag.col3text = "AslunFR est une développeur C# depuis 2017.";

            ViewBag.col4title = "AslunFR";
            ViewBag.col4text = "AslunFR est une développeur C# depuis 2017.";

            ViewBag.activatemenu = "active";

            ViewBag.email = "contact@aslun.fr";
            return View();
        }

        [Route("vps")]
        // GET: Default
        public ActionResult vps()
        {
            //Metaname
            ViewBag.description = "AslunFR est une développeur C# depuis 2017.";

            //Title
            ViewBag.Title = "VPS";

            //Page
            ViewBag.slidertitle = "AslunFR";
            ViewBag.slidertext = "AslunFR est une développeur C# depuis 2017";

            ViewBag.indepedanttitle = "AslunFR";
            ViewBag.indepedant = "AslunFR est une développeur C# depuis 2017";

            ViewBag.col1title = "AslunFR";
            ViewBag.col1text = "AslunFR est une développeur C# depuis 2017.";

            ViewBag.col2title = "AslunFR";
            ViewBag.col2text = "AslunFR est une développeur C# depuis 2017.";

            ViewBag.col3title = "AslunFR";
            ViewBag.col3text = "AslunFR est une développeur C# depuis 2017.";

            ViewBag.col4title = "AslunFR";
            ViewBag.col4text = "AslunFR est une développeur C# depuis 2017.";

            ViewBag.activatemenu = "active";
            ViewBag.email = "contact@aslun.fr";

            //Price
            ViewBag.VPS1 = "VPS 1";
            ViewBag.vcpu1 = "6";
            ViewBag.ram1 = "16";
            ViewBag.disk1 = "30";
            ViewBag.ddos1 = "10G";
            ViewBag.os1 = "Linux";
            ViewBag.price1 = "0.00";
            ViewBag.url1 = "https://synh.fr";

            ViewBag.VPS2 = "VPS 2";
            ViewBag.vcpu2 = "12";
            ViewBag.ram2 = "32";
            ViewBag.disk2 = "40";
            ViewBag.ddos2 = "10G";
            ViewBag.os2 = "Linux";
            ViewBag.price2 = "0.00";
            ViewBag.url2 = "https://synh.fr";


            ViewBag.VPS3 = "VPS 3";
            ViewBag.vcpu3 = "24";
            ViewBag.ram3 = "46";
            ViewBag.disk3 = "50";
            ViewBag.ddos3 = "10G";
            ViewBag.os3 = "Linux";
            ViewBag.price3 = "0.00";
            ViewBag.url3 = "https://synh.fr";

            ViewBag.pricecustom = "0.00";
            ViewBag.urlcustom = "https://synh.fr";

            return View();


        }

        [Route("web")]
        // GET: Default
        public ActionResult webhosting()

        {
            //Metaname
            ViewBag.description = "AslunFR est une développeur C# depuis 2017.";

            //Title
            ViewBag.Title = "Web";

            //Page
            ViewBag.slidertitle = "AslunFR";
            ViewBag.slidertext = "AslunFR est une développeur C# depuis 2017";

            ViewBag.indepedanttitle = "AslunFR";
            ViewBag.indepedant = "AslunFR est une développeur C# depuis 2017";

            ViewBag.col1title = "AslunFR";
            ViewBag.col1text = "AslunFR est une développeur C# depuis 2017.";

            ViewBag.col2title = "AslunFR";
            ViewBag.col2text = "AslunFR est une développeur C# depuis 2017.";

            ViewBag.col3title = "AslunFR";
            ViewBag.col3text = "AslunFR est une développeur C# depuis 2017.";

            ViewBag.col4title = "AslunFR";
            ViewBag.col4text = "AslunFR est une développeur C# depuis 2017.";

            ViewBag.activatemenu = "active";

            ViewBag.email = "contact@aslun.fr";

            //Price
            ViewBag.Host1 = "Web 1";
            ViewBag.webdisk1 = "10";
            ViewBag.website1 = "1";
            ViewBag.db1 = "2";
            ViewBag.webddos1 = "10G";
            ViewBag.support1 = "Inclut";
            ViewBag.webprice1 = "0.00";
            ViewBag.urlweb1 = "https://synh.fr";

            ViewBag.Host2 = "Web 2";
            ViewBag.webdisk2 = "20";
            ViewBag.website2 = "10";
            ViewBag.db2 = "20";
            ViewBag.webddos2 = "10G";
            ViewBag.support2 = "Inclut";
            ViewBag.webprice2 = "0.00";
            ViewBag.urlweb2 = "https://synh.fr";


            ViewBag.Host3 = "Web 3";
            ViewBag.webdisk3 = "30";
            ViewBag.website3 = "100";
            ViewBag.db3 = "200";
            ViewBag.webddos3 = "10G";
            ViewBag.support3 = "Inclut";
            ViewBag.webprice3 = "0.00";
            ViewBag.urlweb3 = "https://synh.fr";

            ViewBag.WebCustomPrice = "0.00";
            ViewBag.UrlWebCustom = "https://synh.fr";

            return View();
        }


    }
}