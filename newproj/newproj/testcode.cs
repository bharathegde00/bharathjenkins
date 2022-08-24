using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
   
    public class testcode
    {
        private object day2function;

        
        public void TestMethod1()
        {
            //Average
            int divid = 50;
            int divisor = 5;
            int res, rem;
            int expectedResult = 20;

            //Act
            ConsoleApp.Mathproj.Divide(divid, divisor,out  res,out  rem);
            Assert.AreEqual(expectedResult, rem);
            Assert.AreEqual(0, rem);
        }
    }
}