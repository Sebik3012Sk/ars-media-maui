using ArsMediaApp.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArsMediaApp.Database
{
    public class Connection
    {
        
        public dynamic connectDb(string connectionString)
        {
            RestClient client = new RestClient(connectionString);
            RestRequest request = new RestRequest();
            RestResponse response = client.Get(request);
            var data = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return data;
        }
    }
}
