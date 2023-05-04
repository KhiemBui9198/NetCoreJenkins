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
    public class HomeControllerTest
    {
        [Fact]
        public void Index()
        {
            var controller = new HomeController();
            var result = controller.Index() as ViewResult;
            Xunit.Assert.Equal("Index", result?.ViewName);
   

        }
       
}
}