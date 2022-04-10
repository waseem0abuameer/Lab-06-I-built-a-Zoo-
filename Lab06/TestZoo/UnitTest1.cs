using System;
using Lab06;
using Xunit;

namespace TestZoo
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Bird_Type()
        {
            Cat alkeh = new Cat(4, "Hot", "blacK");
            Assert.Equal("Cat is Eating  Meet and dray Food", alkeh.Eat1() );

        }

       

    }
}
