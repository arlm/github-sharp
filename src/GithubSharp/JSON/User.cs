using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitHubSharp.JSON
{
    public class User
    {
        public string Login { get; set; }
        public int Id { get; set; }
        public string Avatar_url { get; set; }
        public string Gravatar_id { get; set; }
        public string Url { get; set; }
    }

    public enum UserType
    {
        User,
        Organization
    }
}
