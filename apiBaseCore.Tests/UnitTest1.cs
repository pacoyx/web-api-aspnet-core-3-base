using apiBaseCore.Controllers;
using System;
using Xunit;

namespace apiBaseCore.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            HomeController home = new HomeController();
            string result = home.GetEmployeeName(1);
            Assert.Equal("Jignesh", result);
        }
    }
}
