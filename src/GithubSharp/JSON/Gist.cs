using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitHubSharp.JSON
{
    public class Gist
    {
        public string Url { get; set; }
        public string Id { get; set; }
        public string Description { get; set; }
        public bool Public { get; set; }
        public User User { get; set; }
        public Dictionary<string, File> Files { get; set; }
        public int Comments { get; set; }
        public string Html_url { get; set; }
        public string Git_pull_url { get; set; }
        public string Git_push_url { get; set; }
        public string Created_at { get; set; }
    }
}
