using Microsoft.Extensions.Configuration;

namespace Logic.Tests;

public class BaseLogic
{
    public static string GetConnectionString(string name)
    {
        var config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: true)
        .Build();

        return config.GetConnectionString(name);
    }
}
