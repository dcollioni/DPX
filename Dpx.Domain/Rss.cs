using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dpx.Domain
{
    public class Rss
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public DateTimeOffset PublishDate { get; set; }
        public string Url { get; set; }
    }
}
