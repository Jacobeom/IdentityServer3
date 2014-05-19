﻿using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thinktecture.IdentityServer.Core.Configuration
{
    public class InternalConfiguration
    {
        public PluginDependencies PluginDependencies { get; set; }

        public InternalConfiguration()
        {
            PluginDependencies = new PluginDependencies();
        }
    }
}
