﻿using FirstSite.DAL;
using FirstSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstSite.Controllers
{
    public class HomeController : Controller
    {
        private CursesContext db = new CursesContext();

        public ActionResult Index()
        {
            var listaKategorii = db.Kategories.ToList();

            return View();
        }
    }
}