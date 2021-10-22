using DemoInteraktiva.Models;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DemoInteraktiva.Repositories
{
    public class MockRepository  : IRepository
    {
        private readonly string basePath;

        public MockRepository(IWebHostEnvironment environment)
        {
            basePath = $@"{environment.ContentRootPath}\Mock\";
        }

        public Task<IEnumerable<TotalDto>> GetContryTotal(string countrySlug)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CountryDto>> GetCountriesAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<SummaryDto> GetSummaryAsync()
        {
            await Task.Delay(0);
            return GetTestData<SummaryDto>("summary.json");
        }

        private T GetTestData<T>(string testfile)
        {
            var path = $"{basePath}{testfile}";
            string data = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<T>(data);
        }
    }
}
