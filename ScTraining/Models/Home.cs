using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScTraining.Models
{
    [SitecoreType(AutoMap = true, TemplateId = "{76036F5E-CBCE-46D1-AF0A-4143F9B557AA}")]
    public class Home
    {
        [SitecoreField("Title")]
        public virtual string Title { get; set; }
        [SitecoreField("Text", Setting = Glass.Mapper.Sc.Configuration.SitecoreFieldSettings.RichTextRaw)]
        public virtual string Text { get; set; }
    }
}