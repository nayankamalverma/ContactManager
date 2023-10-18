using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagerTest
{
    
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            MyMath mm = new MyMath();
            int n1 = 2, n2 = 3;
            int expected = 5;

            //Act
            int actual= mm.sum(n1, n2);

            //Assert
            Assert.Equal(expected,actual);

        }
    }
}
