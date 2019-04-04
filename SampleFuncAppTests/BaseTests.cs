using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleFuncAppTests
{
    public class BaseTests
    {
        protected IConfiguration _configuration;

        [SetUp]
        public void Setup()
        {
            _configuration = new ConfigurationBuilder()
                  .AddJsonFile("appsettings.json")
                  .AddJsonFile("appsettings.Development.json")
                  .Build();
        }
    }
}
