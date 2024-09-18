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
    public class Users
    {

        private ConnVars connVars;

        public Users()
        {
            connVars = new ConnVars();
        }

        public dynamic GetUsers()
        {
            RestClient client = new RestClient($"http://localhost:{connVars.GetPort()}/get-data");
            RestRequest request = new RestRequest();
            RestResponse response = client.Get(request);
            var users = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return users;
        }
    }
}
