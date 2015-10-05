using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubAPI.Classes
{
    class RepoInfo
    {
        //Constructor doesnt do anything right now
        public RepoInfo()
        {
        }

        //Repository Information
        public string stargazers_count { get; set; }
        public string name { get; set; }
        public string watchers_count { get; set; }

    }

    
}
