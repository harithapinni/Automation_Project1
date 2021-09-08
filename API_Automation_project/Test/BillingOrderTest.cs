using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace API_Automation_project.Test
{   
    class BillingOrderTest
    {
        string jsonBody = "{\"addressLine1\":\"address1\",\"addressLine2\":\"add2\"," +
                         "\"city\":\"auckland\",\"comment\":\"testcomment\",\"email\":\"ajit@sector36.com\"," +
    "\"firstName\":\"Ajit\",\"itemNumber\":0,\"lastName\":\"Sharma\"," +
    "\"phone\":\"0123456789\",\"state\":\"AL\",\"zipCode\":\"121212\"}";

        string baseUrl = "http://localhost:8080/BillingOrder";

        [Test]
        public void CreateBillingOrder()
        {
            IRestResponse response = Post(jsonBody);
            //printing
            TestContext.WriteLine(response.StatusCode);
            TestContext.WriteLine(response.Content);
        }
        public IRestResponse Post(string body)
        {  //base url
            var client = new RestClient(baseUrl);
            //request
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            //request.AddHeader("Authorization", "bearer {token}"};
            request.AddJsonBody(jsonBody);
            //execution
            IRestResponse response = client.Execute(request);
            return response;
        }

    }
}
