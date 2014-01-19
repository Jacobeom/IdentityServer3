﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Thinktecture.IdentityServer.Core.Connect.Models
{
    public class Scope
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<ScopeClaim> Claims { get; set; }
    }
}
