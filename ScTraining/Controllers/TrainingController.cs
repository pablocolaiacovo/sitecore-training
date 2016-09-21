using Glass.Mapper.Sc;
using ScTraining.Models;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScTraining.Controllers
{
    public class TrainingController : BaseController
    {
        public TrainingController(ISitecoreContext sitecoreContext) : base(sitecoreContext)
        {
        }

        public ActionResult Home()
        {
            var model = SitecoreContext.GetHomeItem<Home>();
            return PartialView("~/Views/Training/Home.cshtml", model);
        }

        public ActionResult Carousel()
        {
            var model = SitecoreContext.GetItem<Carousel>(RenderingContext.Current.Rendering.DataSource);
            return PartialView("~/Views/Training/Carousel.cshtml", model);
        }
    }
}