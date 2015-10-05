using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using GithubAPI.Classes;

namespace GithubAPI
{
    class Program
    {
        public static UserInfo userinfo;
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a GitHub Username");

            string username = Console.ReadLine();

            using (WebClient webClient = new WebClient())
            {
                //Says Hello to GitHub
                webClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

                // Grabs json info from github and saves it to a string.
                string json = webClient.DownloadString("https://api.github.com/users/" + username);

                //this converts the json info into usable information for us
                userinfo = JsonConvert.DeserializeObject<UserInfo>(json);

                string name = userinfo.name;
                string url = userinfo.url;
                string followers = userinfo.followers;
                string public_repos = userinfo.public_repos;
                string repos_url = userinfo.repos_url;

                // writes the information out to the console
                Console.WriteLine("Name: {0}", name);
                Console.WriteLine("URL: {0}", url);
                Console.WriteLine("Followers: {0}", followers);
                Console.WriteLine("Number of Repositories: {0}", public_repos);

                


            }
            
         
                using (WebClient webClient = new WebClient())
            {
                //Says Hello to GitHub
                webClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

                // Grabs json info from github and saves it to a string.
                string repoInfo = webClient.DownloadString("https://api.github.com/users/" + username + "/repos");

                //this converts the json info into usable information for us
                List<RepoInfo> SecondInfo = new List<RepoInfo>();
                SecondInfo = JsonConvert.DeserializeObject<List<RepoInfo>>(repoInfo);
                
                foreach (var item in SecondInfo)
                {
                    Console.WriteLine("Repository: {1} || Stars: {0} || Watchers: {2}", item.stargazers_count, item.name, item.watchers_count);
                }

                Console.ReadLine();

            }
            

        }
    }
}
