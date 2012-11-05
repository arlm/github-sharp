using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitHubSharp.JSON
{
    public class CommitInfo
    {
        public string Url { get; set; }
        public string Sha { get; set; }
    }

    public class CommitEntry : CommitInfo
    {
        public User Author { get; set; }
        public List<CommitInfo> Parents { get; set; }
        public CommitDetail Commit { get; set; }
        public User Committer { get; set; }
    }

    public class CommitDetail
    {
        public CommitUser Author { get; set; }
        public int Commit_count { get; set; }
        public CommitInfo Tree { get; set; }
        public string Message { get; set; }
        public CommitUser Committer { get; set; }
        public string Url { get; set; }
    }

    public class CommitUser {
        public string Date { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
