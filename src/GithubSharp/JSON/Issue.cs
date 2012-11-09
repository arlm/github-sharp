using System.Collections.Generic;

namespace GitHubSharp.JSON
{
    public class Issue
    {
        public int Id { get; set; }
        public Repository Repository { get; set; }
        public string Url { get; set; }
        public string Html_url { get; set; }
        public int Number { get; set; }
        public string State { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public User User { get; set; }
        public List<IssueLabel> Labels { get; set; }
        public User Assignee { get; set; }
        public IssueMilestone Milestone { get; set; }        
        public int Comments { get; set; }
        public IssuePullrequest Pull_request { get; set; }
        public string Closed_at { get; set; }
        public string Created_at { get; set; }
        public string Updated_at { get; set; }
    }
    public class IssueLabel {
        public string Url { get; set; }
        public string Name { get; set; }
        public string color { get; set; }
    }
    public class IssueMilestone {
        public string Url { get; set; }
        public int Number { get; set; }
        public string State { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public User Creator { get; set; }
        public int Open_issues { get; set; }
        public int Closed_issues { get; set; }
        public string Created_at { get; set; }
        public string Due_on { get; set; }
    }
    public class IssuePullrequest
    {
        public string Html_url { get; set; }
        public string Diff_url { get; set; }
        public string Patch_url { get; set; }
    }
}
