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
        [TestMethod]

        public void ToBinary_InputHiAlisa_ReturnsCorrectBinary()
        {
            var converter = new BinaryConverter();
            string input = "Hi Alisa";
            string expected = "01001000 01101001 00100000 01000001 01101100 01101001 01110011 01100001";
            string result = converter.ToBinary(input);
            Assert.AreEqual(expected, result);
        }

    }
}