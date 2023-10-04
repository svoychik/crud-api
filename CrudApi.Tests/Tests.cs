using System.Net;

namespace CrudApi.Tests;

public class Tests
{
    [Fact]
    public async Task Should_Return_200_With_Hello_World_Content()
    {
        var factory = new ApiFactory();
        var client = factory.CreateClient();

        var result = await client.GetAsync("/hello");
        
        Assert.Equal(HttpStatusCode.OK,result.StatusCode);
    }
}