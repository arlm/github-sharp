using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GitHubSharp;
using GitHubSharp.JSON;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            GitHub github = new GitHub("username", "password");

            Rate rate = github.Limit;

            Console.Out.WriteLine("Limit {0} of {1}", rate.Remaining, rate.Limit);

            Console.In.Read();
        }
    }
}
