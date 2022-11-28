using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace DigitalLearningSolutions.Helpers
{
    public static class ConfigHelper
    {
        public const string DefaultConnectionStringName = "DefaultConnection";
        public const string UnitTestConnectionStringName = "UnitTestConnection";

        public static IConfigurationRoot GetAppConfig()
        {
            return new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(GetAppSettingsFilename())
                .AddEnvironmentVariables(GetEnvironmentVariablePrefix())
                .Build();
        }

        public static string GetEnvironmentVariablePrefix()
        {
            var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            return $"DlsRefactor{environmentName}_";
        }

        private static string GetAppSettingsFilename()
        {
            var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            return "appsettings.json";
        }
    }
}
