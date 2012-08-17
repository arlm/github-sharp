using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp;
using GitHubSharp.JSON;
using GitHubSharp.Auth;

namespace GitHubSharp
{
    public partial class GitHub
    {
        private const string apiRepo = "https://api.github.com";

        public RestClient client;

        public GitHub()
        {
            client = new RestClient
            {
                BaseUrl = apiRepo
            };

            client.AddDefaultHeader("Accept", "application/vnd.github.beta+json");
        }

        public GitHub(string username, string password) :
            this()
        {
            client.Authenticator = new Authenticator(username, password, false);
        }

        public GitHub(string secrestPath) :
            this()
        {
            client.Authenticator = new Authenticator(secrestPath, false);
        }

        public Rate Limit
        {
            get
            {
                var request = new RestRequest
                    {
                        Resource = "/rate_limit", 
                        Method = Method.GET,
                        RootElement = "rate"
                    };

                var response = client.Execute<Rate>(request);

                return response.Data;
            }
        }

        public void Authorize(string appName, string url)
        {
            var request = new RestRequest("authorizations", Method.POST);
            request.AddParameter("note", appName);
            request.AddParameter("note_url", url);
            var response = client.Execute<Rate>(request);
        }
    }
}
