
//#########################################################
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
using System.Resources;

namespace Efredia.Controllers
{


    public class HomeController : Controller
    {

        // GET: Default
        public ActionResult Index()
        {
            ViewBag.metaname = "L'association Synhostinger est une association de loi 1901 vous proposant de propulser vos projets à des tarifs attractif.";
            ViewBag.Title = "Accueil";
            ViewBag.Project = "Synhostinger";
            ViewBag.indepedanttitle = "Indépendant";
            ViewBag.indepedant = "Synhostinger héberge tous ses services sur son réseau (AS212816)";
            ViewBag.dellhptitle = "Serveur HP / Dell";
            ViewBag.dellhp = "Synhostinger utilises du matériel de grand constructeur.";
            ViewBag.Replicationtitle = "Réplication";
            ViewBag.Replication = "Nos sauvergardes se font uniquement sur des serveurs Français.";
            ViewBag.Support = "Support";
            ViewBag.SupportText = "Notre équipe de techniciens qualifiés est à votre disposition ";
            ViewBag.Banner = "Chez Synhostinger, nous fournissons le support est l'hébergement de qualité !";
            ViewBag.activatemenu = "active";
            return View();
        }


        [Route("404")]
        // GET: Default
        public ActionResult Error()
        {
            ViewBag.Project = "Synhostinger";
            ViewBag.Title = "Erreur 404";
            ViewBag.metaname = "Ouupss... Erreur 404, notre serveur web à du manger la page :)";
            ViewBag.Title = "Ouupss... Erreur 404";
            return View();

        }

        [Route("About")]
        // GET: Default
        public ActionResult About()
        {
            ViewBag.Title = "Information";
            ViewBag.Project = "Synhostinger";
            ViewBag.indepedanttitle = "Indépendant";
            ViewBag.indepedant = "Synhostinger héberge tous ses services sur son réseau (AS212816)";
            ViewBag.dellhptitle = "Serveur HP / Dell";
            ViewBag.dellhp = "Synhostinger utilises du matériel de grand constructeur pour noous permettre de garantir la qualité de notre infrastructure.";
            ViewBag.Replicationtitle = "Réplication";
            ViewBag.Replication = "Nos sauvergardes se font uniquement sur des serveurs Français pour un respect total de vos données";
            return View();
        }

        [Route("vps")]
        // GET: Default
        public ActionResult vps()
        {
            ViewBag.Title = "Performance et prix bas";
            ViewBag.VPSButton = "Précommander";
            ViewBag.Project = "Synhostinger";
            ViewBag.activatemenu = "active";
            ViewBag.indepedanttitle = "Indépendant";
            ViewBag.indepedant = "Synhostinger héberge tous ses services sur son réseau (AS212816)";
            ViewBag.dellhptitle = "Serveur HP / Dell";
            ViewBag.dellhp = "Synhostinger utilises du matériel de grand constructeur pour noous permettre de garantir la qualité de notre infrastructure.";
            ViewBag.Replicationtitle = "Réplication";
            ViewBag.Replication = "Nos sauvergardes se font uniquement sur des serveurs Français pour un respect total de vos données";
            return View();
        }

        [Route("web")]
        // GET: Default
        public ActionResult webhosting()
        {
            ViewBag.Title = "Le meilleur de l'hébergement";
            ViewBag.VPSButton = "Précommander";
            ViewBag.Project = "Synhostinger";
            ViewBag.indepedanttitle = "Indépendant";
            ViewBag.activatemenu = "active";
            ViewBag.indepedant = "Synhostinger héberge tous ses services sur son réseau (AS212816)";
            ViewBag.dellhptitle = "Serveur HP / Dell";
            ViewBag.dellhp = "Synhostinger utilises du matériel de grand constructeur pour noous permettre de garantir la qualité de notre infrastructure.";
            ViewBag.Replicationtitle = "Réplication";
            ViewBag.Replication = "Nos sauvergardes se font uniquement sur des serveurs Français pour un respect total de vos données";
            return View();
        }


    }
}