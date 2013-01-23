using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Raven.Client.Document;
using Dpx.Presentation.Controllers;

namespace Dpx.Presentation.Configuration
{
    public static class RavenDbConfig
    {
        public static void Configure()
        {
            RavenController.Store = new DocumentStore { ConnectionStringName = "RavenDB" }.Initialize();
        }
    }
}
