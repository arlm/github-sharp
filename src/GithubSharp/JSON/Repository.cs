using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitHubSharp.JSON
{
    public class Repository
    {
        public int Forks { get; set; }
        public string Language { get; set; }
        public string Created_at { get; set; }
        public string Description { get; set; }
        public string Ssh_url { get; set; }
        public User Owner { get; set; }
        public bool Has_downloads { get; set; }
        public string Updated_at { get; set; }
        public int Forks_count { get; set; }
        public string Svn_url { get; set; }
        public Permissions Permissions { get; set; }
        public bool Has_wiki { get; set; }
        public string Git_url { get; set; }
        public string Html_url { get; set; }
        public int Watchers { get; set; }
        public int Size { get; set; }
        public bool Fork { get; set; }
        public string Full_name { get; set; }
        public int Watchers_count { get; set; }
        public string Clone_url { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int Open_issues { get; set; }
        public object Mirror_url { get; set; }
        public bool Has_issues { get; set; }
        public string Homepage { get; set; }
        public bool Private { get; set; }
        public int Id { get; set; }
        public int Open_issues_count { get; set; }
        public string Pushed_at { get; set; }
        public string Master_branch { get; set; }
        public int Network_count { get; set; }
    }
}
