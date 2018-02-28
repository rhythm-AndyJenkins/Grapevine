using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Owin;
using Microsoft.Owin;

[assembly: OwinStartup(typeof(Our.Umbraco.Grapevine.Application))]

namespace Our.Umbraco.Grapevine {
    public class Application {

        public void Configuration(IAppBuilder app) {
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
        }

    }
}
