using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NetCoreJenkins;
using NetCoreJenkins.Controllers;
using NetCoreJenkins.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [Fact]
        public void Index()
        {
            var model = new Employee()
            {
                LastName = "LastName test",
                FirstName= "FirstName test",
                Address = " Address test"
            };
            var results = string.Format("Form Field Value is : {0} {1} {2}", model.FirstName, model.LastName, model.Address);
            Xunit.Assert.NotNull(results);

        }

        private IEnumerable<Employee> GetTestEmployees()
        {
            return new List<Employee>()
            {
                new Employee()
                {
                    FirstName = "A",
                    LastName = "John",
                    Address = "sadas"
                },
                new Employee()
                {
                    FirstName = "A",
                    LastName = "John",
                    Address = "dsadas"
                }
            };


        }
}

    internal class TestClassAttribute : Attribute
    {
    }
}