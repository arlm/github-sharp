using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp.Serializers;
using RestSharp.Deserializers;

namespace GitHubSharp.JSON
{
    public class Rate
    {      
        public int Remaining { get; set; }
        public int Limit { get; set; }
    }
}
