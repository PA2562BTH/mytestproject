using BTH.Sha256Sum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Sha256Sum.Test
{
    [TestClass]
    public class Sha256CalculatorTest
    {
        [TestMethod]
        public void should_calculate_hash()
        {
            // Arrange
            byte[] bytesToHash = { 1, 2, 3 };

            // Act
            string hexString = Sha256Calculator.Calculate(new MemoryStream(bytesToHash));

            // Assert
            Assert.AreEqual("039058c6f2c0cb492c533b0a4d14ef77cc0f78abccced5287d84a1a2011cfb81", hexString);
        }
    }
}
