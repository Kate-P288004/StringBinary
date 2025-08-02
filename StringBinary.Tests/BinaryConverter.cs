using System;
using System.Linq;

namespace StringBinary
{
    public class BinaryConverter
    {
        public string ToBinary(string input)
        {
            if (string.IsNullOrEmpty(input)) return string.Empty;

            return string.Join(" ", input.Select(c => Convert.ToString(c, 2).PadLeft(8, '0')));
        }
    }
}
