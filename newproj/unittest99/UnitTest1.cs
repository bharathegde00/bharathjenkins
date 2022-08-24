using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace unittest99
{
    
    public class UnitTest1
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
            unittestcon.Program.Divide(divid, divisor,out res, out rem);
            Assert.AreEqual(expectedResult, rem);
            Assert.AreEqual(0, rem);
        }
    }
}