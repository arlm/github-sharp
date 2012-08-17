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
            GitHub github = new GitHub(@"%USERPROFILE%\secret.xml");

            Rate rate = github.Limit;
            
            Console.Out.WriteLine("Limit {0} of {1}", rate.Remaining, rate.Limit);

            List<Repository> repos = github.MyRepositories;
            Console.Out.WriteLine("{0} Repositories:", repos.Count);

            foreach (Repository repo in repos)
            {
                Console.Out.Write("{0},", repo.Name);
            }

            Console.Out.WriteLine("\n\nRepository {0}:\n{1}", repos[0].Name, repos[0].Dump());

            Console.ReadKey();

            Console.Out.WriteLine("\n\nRepository GET {0}:\n{1}", repos[0].Name, github.GetRepository(repos[0].Owner.Login, repos[0].Name).Dump());

            Console.ReadKey();

            List<Organization> orgs = github.MyOrganizations;
            Console.Out.WriteLine("{0} Organizations:", orgs.Count);

            foreach (Organization org in orgs)
            {
                Console.Out.Write("{0},", org.Name);
            }

            Console.Out.WriteLine("\n\nOrganization {0}:\n{1}", orgs[0].Company, orgs[0].Dump());

            Console.ReadKey();

            Console.Out.WriteLine("\n\nOrganization GET {0}:\n{1}", orgs[0].Login, github.GetOrganization(orgs[0].Login).Dump());

            Console.ReadKey();

            List<Repository> orgRepos = github.GetRepositories(orgs[0].Login, UserType.Organization);
            Console.Out.WriteLine("{0} Repositories:", orgRepos.Count);

            foreach (Repository repo in orgRepos)
            {
                Console.Out.Write("{0},", repo.Name);
            }

            Console.Out.WriteLine("\n\nRepository {0}:\n{1}", orgRepos[0].Name, orgRepos[0].Dump());

            Console.ReadKey();
        }
    }
}
