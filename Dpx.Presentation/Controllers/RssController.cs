using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.ServiceModel.Syndication;
using Dpx.Domain.Extensions;
using Dpx.Domain;

namespace Dpx.Presentation.Controllers
{
    public class RssController : RavenController
    {
        public ActionResult Index()
        {
            return View();
        }

        ///<item>
        ///  <title>RSS Resources</title>
        ///  <link>http://www.webreference.com/authoring/languages/xml/rss/intro/index.html</link>
        ///  <description>Defined in XML, the Rich Site Summary (RSS) format has
        ///  quietly become a dominant format for distributing headlines on the Web.
        ///  Our list of links gives you the tools, tips and tutorials you need to get
        ///  started using RSS. 0323</description>
        ///</item>
        public ActionResult List()
        {
            const string url = "http://rss.noticias.uol.com.br/economia/ultnot/index.xml";
            using (XmlReader reader = XmlReader.Create(url))
            {
                var items = SyndicationFeed.Load(reader).Items
                    .Select(x => new {
                        Title = x.Title.Text,
                        Link = x.Links.First().Uri.ToString(),
                        Description = x.Summary.Text,
                        PublishDate = x.PublishDate
                    }).ExceptWhere(x => x.Description.IsBlank());
                return Json(items);
            }
        }
    }
}
