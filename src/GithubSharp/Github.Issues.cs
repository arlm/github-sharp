using GitHubSharp.JSON;
using RestSharp;
using System.Collections.Generic;

namespace GitHubSharp
{
    public partial class GitHub
    {
        public List<Issue> GetOrganizationIssues(string organization, string filter = "all")
        {
            var request = new RestRequest
            {
                Resource = "/orgs/{org}/issues?filter={filter}",
                Method = Method.GET
            };

            request.AddUrlSegment("org", organization);
            request.AddUrlSegment("filter", filter);

            var response = client.Execute<List<Issue>>(request);

            return response.Data;
        }
        public List<Issue> GetUserIssues(string user, string filter = "all")
        {
            var request = new RestRequest
            {
                Resource = "/user/{user}/issues?filter={filter}",
                Method = Method.GET
            };

            request.AddUrlSegment("user", user);
            request.AddUrlSegment("filter", filter);

            var response = client.Execute<List<Issue>>(request);

            return response.Data;
        }
    }
}
