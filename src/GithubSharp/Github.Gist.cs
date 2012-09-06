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
        public List<Gist> MyGists
        {
            get
            {
                var request = new RestRequest
                {
                    Resource = "/gists",
                    Method = Method.GET
                };

                var response = client.Execute<List<Gist>>(request);

                return response.Data;
            }
        }

        public Gist GetGist(string id)
        {
            var request = new RestRequest
            {
                Resource = "/gists/{id}",
                Method = Method.GET
            };

            request.AddUrlSegment("id", id);

            var response = client.Execute<Gist>(request);

            return response.Data;
        }

        public List<Gist> GetGists(string login)
        {
            var request = new RestRequest
            {
                Resource = "/{user}/gists",
                Method = Method.GET
            };


            request.AddUrlSegment("user", login);

            var response = client.Execute<List<Gist>>(request);

            return response.Data;
        }
    }
}
