using System;
using Xunit;

namespace CircleCITest.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1_Success()
        {
            var result = false;

            Assert.False(result, "False result");
        }

        [Fact]
        public void Test2_Fail()
        {
            var result = true;

            Assert.True(result, "True result, should fail");
        }
    }
}
