using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorApp1.Server.Services
{
    public class HighScoreService : IHighScoreService
    {
        private readonly HttpClient httpClient;
        public HighScoreService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<HighScoreService>> GetEmployees()
        {
            return null;
        }
    }
    
}
