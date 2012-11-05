using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitHubSharp.JSON
{
    public class Download
    {
        public string Url { get; set; }
        public string Html_url { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long Size { get; set; }
        public int Download_count { get; set; }
        public string contecnt_type { get; set; }
    }
}
