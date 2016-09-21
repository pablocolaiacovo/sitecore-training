using Castle.Core.Logging;
using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScTraining.Controllers
{
    public class BaseController : GlassController
    {
        public ILogger Logger { get; set; }
            
        protected BaseController(ISitecoreContext sitecoreContext) : base(sitecoreContext)
        {
        }
    }
}