﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace DemoInteraktiva.Infrastructure
{
    public class ApiClient : IApiClient
    {
        private readonly HttpClient client = new HttpClient();

        // Generiska metoder

        public async Task<T> GetAsync<T>(string endpoint)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, endpoint);
            try
            {
                using var response = await client.SendAsync(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var responseJson = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<T>(responseJson);
                    return data;
                }
                if (response.StatusCode == HttpStatusCode.TooManyRequests)
                {

                    throw new Exception("För många anrop mot api");
                }
                throw new Exception("Felaktigt api-anrop");

            }
            catch (Exception)
            {
                throw;
            }
          
        }
    }
}
