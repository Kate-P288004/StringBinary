using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringBinary;

namespace StringBinary.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ToBinary_InputKate_ReturnsCorrectBinary()
        {
            var converter = new BinaryConverter();
            string input = "Kate";
            string expected = "01001011 01100001 01110100 01100101";

            string result = converter.ToBinary(input);

            Assert.AreEqual(expected, result);
        }
    }
}
