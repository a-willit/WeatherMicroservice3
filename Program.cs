﻿using System;
using System.Collections.Generic;
using System.IO; 
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting; 
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace WeatherMicroservice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }
//                .UseUrls("http://*:1000")

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseConfiguration(new ConfigurationBuilder().Build())
                .UseStartup<Startup>()
                .Build();
    }
}
