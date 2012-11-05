using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GitHubSharp.JSON;
using RestSharp;

namespace GitHubSharp
{
    public partial class GitHub
    {
        public List<Download> GetDownloads(string owner, string repo)
        {
            var request = new RestRequest
            {
                Resource = "/repos/{owner}/{repo}/downloads",
                Method = Method.GET
            };

            request.AddUrlSegment("owner", owner);
            request.AddUrlSegment("repo", repo);

            var response = client.Execute<List<Download>>(request);

            return response.Data;
        }
    }
}
