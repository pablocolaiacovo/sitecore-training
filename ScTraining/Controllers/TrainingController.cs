﻿using Glass.Mapper.Sc;
using ScTraining.Models;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScTraining.Controllers
{
    public class TrainingController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var context = new SitecoreContext();
            var model = context.GetHomeItem<Home>();
            return PartialView("~/Views/Training/Index.cshtml", model);
        }

        public ActionResult Carousel()
        {
            var context = new SitecoreContext();
            var model = context.GetItem<Carousel>(RenderingContext.Current.Rendering.DataSource);
            return PartialView("~/Views/Training/Carousel.cshtml", model);
        }
    }
}