using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDExampleApp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Create an instance to test:
            Rooter rooter = new Rooter();
            // Define a test input and output value:
            double expectedResult = 2.0;
            double input = expectedResult * expectedResult;
            // Run the method under test:
            double actualResult = rooter.SquareRoot(input);
            // Verify the result:
            Assert.AreEqual(expectedResult, actualResult, delta: expectedResult / 100);
        }
    }

    public class Rooter
    {
        internal double SquareRoot(double input)
        {
            // Implementación de la raíz cuadrada:
            return Math.Sqrt(input);
        }
    }
}
