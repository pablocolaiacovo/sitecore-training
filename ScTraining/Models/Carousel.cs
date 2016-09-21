using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScTraining.Models
{
    [SitecoreType(AutoMap = true, TemplateId = "{2025CC8D-BFBA-44B8-96D9-A8A6FCD625A4}")]
    public class Carousel
    {
        [SitecoreField("Items", FieldType = SitecoreFieldType.Multilist)]
        public virtual IEnumerable<Article> Items { get; set; }
    }
}