using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArsMediaApp.Database.VARS;

namespace ArsMediaApp.Database.GET
{
    public class Posts
    {

        private ConnVars connVars;

        public Posts()
        {
            connVars = new ConnVars();
        }

        public dynamic GetPosts()
        {
            RestClient client = new RestClient($"http://localhost:{connVars.GetPort()}/get-post");
            RestRequest request = new RestRequest();
            RestResponse response = client.Get(request);
            var posts = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return posts;
        }
    }
}
