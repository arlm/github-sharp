using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitHubSharp.JSON
{
    public class Permissions
    {
        public bool Pull { get; set; }
        public bool Push { get; set; }
        public bool Admin { get; set; }
    }
}
