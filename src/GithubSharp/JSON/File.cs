using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitHubSharp.JSON
{
    public class File
    {
        public int Size { get; set; }
        public string Filename { get; set; }
        public string Raw_url { get; set; }
        public string Content { get; set; }
    }
}
