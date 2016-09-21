using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScTraining.Models
{
    [SitecoreType(AutoMap = true, TemplateId = "{266174F5-F37E-404C-96C6-1E3D933129B4}")]
    public class Article
    {
        [SitecoreField("Title")]
        public virtual string Title { get; set; }
        [SitecoreField("Summary")]
        public virtual string Summary { get; set; }
        [SitecoreField("Image")]
        public virtual Image Image { get; set; }

        [SitecoreField("Body", Setting = SitecoreFieldSettings.RichTextRaw)]
        public virtual string Body { get; set; }
    }
}