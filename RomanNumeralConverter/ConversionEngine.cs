using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumeralConverter
{
    public class ConversionEngine
    {
        public string ConvertNumbers(int numberToConvert)
        {
            if ((numberToConvert < 0) || (numberToConvert > 3999)) throw new ArgumentOutOfRangeException("You've entered an invalid number");
            if (numberToConvert < 1) return string.Empty;
            if (numberToConvert >= 1) return "I" + ConvertNumbers(numberToConvert - 1);
            throw new ArgumentOutOfRangeException("Error");
        }
    }
}
