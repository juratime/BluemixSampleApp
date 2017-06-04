using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotVVM.Framework.Configuration;

namespace WebApplication
{
    public class DotvvmStartup : IDotvvmStartup
    {
        public void Configure(DotvvmConfiguration config, string applicationPath)
        {
#if !DEBUG
            config.Debug = false;
#endif

            // register your routes, controls and resources here
        }
    }
}
