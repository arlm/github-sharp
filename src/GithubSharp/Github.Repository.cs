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
        public List<Repository> MyRepositories
        {
            get
            {
                var request = new RestRequest
                {
                    Resource = "/user/repos",
                    Method = Method.GET
                };

                var response = client.Execute<List<Repository>>(request);

                return response.Data;
            }
        }

        public Repository GetRepository(string login, string name)
        {
            var request = new RestRequest
            {
                Resource = "/repos/{user}/{repo}",
                Method = Method.GET
            };

            request.AddUrlSegment("user", login);
            request.AddUrlSegment("repo", name);

            var response = client.Execute<Repository>(request);

            return response.Data;
        }

        public List<Repository> GetRepositories(string login, UserType type)
        {
            var request = new RestRequest
            {
                Resource = "/{type}/{user}/repos",
                Method = Method.GET
            };


            switch (type)
            {
                case UserType.Organization:
                    request.AddUrlSegment("type", "orgs");
                    break;
                case UserType.User:
                    request.AddUrlSegment("type", "users");
                    break;
            }

            request.AddUrlSegment("user", login);

            var response = client.Execute<List<Repository>>(request);

            return response.Data;
        }
    }
}
