﻿using IdentityBase.Configuration;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace IdentityBase.Public.IntegrationTests
{
    [Collection("Landing Page")]
    public class GeneralTests
    {
        private HttpClient _client;
        private TestServer _server;

        public GeneralTests()
        {
            _server = ServerHelper.CreateServer((services) =>
            {
                services.AddSingleton(new ApplicationOptions());
            }); 

            _client = _server.CreateClient();
        }

        //[Fact]
        public async Task GetIndex()
        {
            // Act
            var response = await _client.GetAsync("/");

            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
        }
    }
}