﻿using ElectronNET.API;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace BlazorPlayground.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                          .UseConfiguration(new ConfigurationBuilder()
                                            .AddCommandLine(args)
                                            .Build())
                          .UseElectron(args)
                          .UseStartup<Startup>()
                          .Build();
        }
    }
}