using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Mvc.Testing;
using PalTracker;

namespace PalTrackerTests
{
    public static class IntegrationTestServer
    {
<<<<<<< HEAD
        public static TestServer Start()
        {
            if (string.IsNullOrEmpty(System.Environment.GetEnvironmentVariable("WELCOME_MESSAGE")))
            {
                System.Environment.SetEnvironmentVariable("WELCOME_MESSAGE", "Default message");
            }
            return new WebApplicationFactory<Program>().Server;
        }
=======
        public static TestServer Start() =>
            new WebApplicationFactory<Program>().Server;
>>>>>>> e7f07dd... Add tests for externalized configuration lab
    }
}