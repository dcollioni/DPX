using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Web.WebPages.OAuth;
using Raven.Client.Document;

namespace Dpx
{
    public static class DocumentStoreConfig
    {
        public static void Configure()
        {
            if (MvcApplication.DocumentStore != null) return; // prevent misuse
            MvcApplication.DocumentStore = new DocumentStore { ConnectionStringName = "RavenDB" }.Initialize();
        }
    }
}
