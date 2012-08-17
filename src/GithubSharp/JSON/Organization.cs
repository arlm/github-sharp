using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitHubSharp.JSON
{
    public class Organization
    {
        public string Login { get; set; }
        public int Id { get; set; }
        public string Url { get; set; }
        public string Avatar_url { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Blog { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public int Public_repos { get; set; }
        public int Public_gists { get; set; }
        public int Followers { get; set; }
        public int Following { get; set; }
        public string Html_url { get; set; }
        public string Created_at { get; set; }
        public string Type { get; set; }
        public string Billing_email { get; set; }
        public int Collaborators { get; set; }
        public int Total_private_repos { get; set; }
        public int Owned_private_repos { get; set; }
        public int Private_gists { get; set; }
        public int Disk_usage { get; set; }
        public Plan Plan { get; set; }
    }
}
