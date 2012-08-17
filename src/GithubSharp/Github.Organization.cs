using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GitHubSharp.JSON;
using RestSharp;

namespace GitHubSharp
{
    partial class GitHub
    {
        public List<Organization> MyOrganizations
        {
            get
            {
                var request = new RestRequest
                {
                    Resource = "/user/orgs",
                    Method = Method.GET
                };

                var response = client.Execute<List<Organization>>(request);

                return response.Data;
            }
        }

        public Organization GetOrganization(string login)
        {
            var request = new RestRequest
            {
                Resource = "/orgs/{org}",
                Method = Method.GET
            };

            request.AddUrlSegment("org", login);

            var response = client.Execute<Organization>(request);

            return response.Data;
        }
    }
}
