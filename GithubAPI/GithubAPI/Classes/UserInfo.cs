using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubAPI
{
   public class UserInfo
    {
        public string name { get; set; }
        public string url { get; set; }
        public string followers { get; set; }
        public string public_repos { get; set; }
        public string repos_url { get; set; }

    }
}
