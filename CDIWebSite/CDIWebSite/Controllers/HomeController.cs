﻿using CDIWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CDIWebSite.Services;
using CDIWebSite.DataContext;

namespace CDIWebSite.Controllers
{
    public class HomeController : Controller
    {
        CDIWebSiteToEntitiesDB db = new CDIWebSiteToEntitiesDB();
        InscriptionsServices i = new InscriptionsServices();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult JoinUs()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Growth()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Preachings()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Care()
        {
            return View();
        }

        [HttpGet]
        public ActionResult VideoStream()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Reservations(int? IdEvento)
        {
            //if(IdEvento == null)
            //{
            //    return RedirectToAction("Index");
            //}
            //Evento e = new Evento();
            //e.IdEvento = (int)IdEvento;
            //return View(e);
            return View();
        }

        [HttpPost]
        public ActionResult Reservations(InscriptionsVM model)
        {
            if (i.CuposState(model.IdEvento))
            {
                if (i.verifyIfExistMail(model.Correo))
                {
                    i.addInscriptionIfUserExist(model);
                }
                else
                {
                    model = i.addPersona(model);
                    i.addInscription(model);
                }
            }
            else
            {
                ViewBag.Message = "Error";
            }
            return View();
        }

        //------------------------------------------ END POINTS ------------------------------------------
        public JsonResult IfExist(string mail)
        {
            bool Exito = i.verifyIfExistMail(mail);
            return Json(Exito, JsonRequestBehavior.AllowGet);
        }
    }
}