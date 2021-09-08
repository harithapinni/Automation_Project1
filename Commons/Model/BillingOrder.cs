﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Commons.Model
{
   public  class BillingOrder
    {
        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("addressLine2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("itemNumber")]
        public int ItemNumber { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        public BillingOrder(string addressLine1 = null, string addressLine2 = null, string city = null, string comment = null,
            string email = null, string firstName = null, int itemNumber = 0, string lastName = null, string phone = null,
            string state = null, string zipCode = null)
        {
            AddressLine1 = addressLine1 ?? "testing";
            AddressLine2 = addressLine2 ?? "test";
            City = city ?? "Auckland";
            Comment = comment ?? " Comment";
            Email = email ?? "abc123@gmail.com";
            FirstName = firstName ?? "Arihan";
            ItemNumber = itemNumber;
            LastName = lastName ?? "Pinni";
            Phone = phone ?? "0123456789";
            State = state ?? "AL";
            ZipCode = zipCode ?? "1024";

            /*AddressLine1 = addressLine1 ?? TestContext.CurrentContext.Random.GetString(10);
            AddressLine2 = addressLine2 ?? "test";*/

        }

        public BillingOrder()
        {
        }
    }
}
