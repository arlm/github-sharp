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
        public List<CommitEntry> GetCommits(string owner, string repo, string branch="master")
        {
            var request = new RestRequest
            {
                Resource = "/repos/{owner}/{repo}/commits/{branch}",
                Method = Method.GET
            };

            request.AddUrlSegment("owner", owner);
            request.AddUrlSegment("repo", repo);
            request.AddUrlSegment("branch", branch);

            var response = client.Execute<List<CommitEntry>>(request);

            return response.Data;
        }
    }
}
