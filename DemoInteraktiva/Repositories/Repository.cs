using DemoInteraktiva.Infrastructure;
using DemoInteraktiva.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoInteraktiva.Repositories
{
    public class Repository : IRepository
    {
        private readonly string key;
        private readonly IApiClient apiClient;
        private readonly IConfiguration configuration;
        private readonly string baseEndpoint = "https://api.covid19api.com";
        public Repository(IApiClient apiClient, IConfiguration configuration)
        {
           
            this.apiClient = apiClient;
            this.configuration = configuration;
            key = configuration["Omdb:ApiKey"];
        }
        public async Task<SummaryDto> GetSummaryAsync()
        {
            var result = await apiClient.GetAsync<SummaryDto>($"{baseEndpoint}/summary");
            return result;
        }

        public async Task<IEnumerable<CountryDto>> GetCountriesAsync() =>  await apiClient.GetAsync<IEnumerable<CountryDto>>($"{baseEndpoint}/countries");
        
        public async  Task<IEnumerable<TotalDto>> GetContryTotal(string countrySlug)
         =>  await apiClient.GetAsync<IEnumerable<TotalDto>>($"{baseEndpoint}/country/{countrySlug}/status/confirmed");

    }
}
