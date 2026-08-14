using System.Net;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Logging;

namespace AiDeveloperLab.Tests;

public class ProductsEndpointTests(ProductsEndpointTests.ProductsApplicationFactory factory) : IClassFixture<ProductsEndpointTests.ProductsApplicationFactory>
{
    [Fact]
    public async Task GetProducts_ReturnsProductsWithNameAndPrice()
    {
        using var client = factory.CreateClient();

        var response = await client.GetAsync("/products");
        var products = await response.Content.ReadFromJsonAsync<Product[]>();

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        Assert.NotNull(products);
        Assert.NotEmpty(products);
        Assert.All(products, product =>
        {
            Assert.False(string.IsNullOrWhiteSpace(product.Name));
            Assert.True(product.Price >= 0);
        });
    }

    public class ProductsApplicationFactory : WebApplicationFactory<Program>
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureLogging(logging => logging.ClearProviders());
        }
    }
}
