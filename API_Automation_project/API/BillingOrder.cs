using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace API_Automation_project.API
{
    class BillingOrder
    {
        string baseUrl = "http://localhost:8080/BillingOrder";
        public IRestResponse GetAll()
        {
            var client = new RestClient(baseUrl);
            //request
            var request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "application/json");
            //request.AddHeader("Authorization", "bearer {token}"};

            //execution
            return  client.Execute(request);
            
        }

        public IRestResponse Post(string body) 
        {
            var client = new RestClient(baseUrl);
            //request
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            //request.AddHeader("Authorization", "bearer {token}"};
            request.AddJsonBody(body);
            //execution
            IRestResponse response = client.Execute(request);
            return response;
        }
        public IRestResponse Put(string id, string body)
        {
            var client = new RestClient($"{baseUrl}/{id}");
            //request
            var request = new RestRequest(Method.PUT);
            request.AddHeader("Content-Type", "application/json");
            //request.AddHeader("Authorization", "bearer {token}"};

            //execution
            return client.Execute(request);
        }
        public IRestResponse Delete(string id)
        {
            var client = new RestClient($"{baseUrl}/{id}");
            //request
            var request = new RestRequest(Method.DELETE);
            request.AddHeader("Content-Type", "application/json");
            //request.AddHeader("Authorization", "bearer {token}"};

            //execution
            return client.Execute(request);
        }
        public IRestResponse Get(string id)
        {
            var client = new RestClient($"{baseUrl}/{id}");
            //request
            var request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "application/json");
            //request.AddHeader("Authorization", "bearer {token}"};

            //execution
            return client.Execute(request);

        }
    }
}
