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
            if (numberToConvert >= 9) return "IX" + ConvertNumbers(numberToConvert - 9);
            if (numberToConvert >= 5) return "V" + ConvertNumbers(numberToConvert - 5);
            if (numberToConvert >= 1) return "I" + ConvertNumbers(numberToConvert - 1);
            throw new ArgumentOutOfRangeException("Error");
        }
    }
}
