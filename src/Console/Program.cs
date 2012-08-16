using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GitHubSharp;
using GitHubSharp.JSON;
using ServiceStack.Text;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            GitHub github = new GitHub("username", "password");

            Rate rate = github.Limit;
            
            Console.Out.WriteLine("Limit {0} of {1}", rate.Remaining, rate.Limit);

            List<Repo> repos = github.Repos;
            Console.Out.WriteLine("{0} Repos:", repos.Count);

            foreach (Repo repo in repos)
            {
                Console.Out.Write("{0},", repo.Name);
            }

            Console.Out.WriteLine("\n\nRepo {0}:\n{1}", repos[0].Name, repos[0].Dump());

            Console.In.Read();
        }
    }
}
