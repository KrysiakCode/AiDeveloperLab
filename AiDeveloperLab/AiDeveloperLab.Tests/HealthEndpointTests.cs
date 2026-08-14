using System.Net;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Logging;

namespace AiDeveloperLab.Tests;

public class HealthEndpointTests(HealthEndpointTests.HealthApplicationFactory factory) : IClassFixture<HealthEndpointTests.HealthApplicationFactory>
{
    [Fact]
    public async Task GetHealth_ReturnsOk()
    {
        using var client = factory.CreateClient();

        var response = await client.GetAsync("/health");

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }

    public class HealthApplicationFactory : WebApplicationFactory<Program>
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureLogging(logging => logging.ClearProviders());
        }
    }
}
