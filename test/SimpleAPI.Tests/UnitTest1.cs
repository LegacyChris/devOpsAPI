using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Tests
{

    public class UnitTest1
    {
       
        [Fact]
        public void Test1()
        {

        }

         ValuesController controller = new ValuesController();
        [Fact]
        public void GetExpectedResult()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("value", returnValue.Value);
        }
    }
}
