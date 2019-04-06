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
            if (numberToConvert >= 3999) return "MMMCMX" + ConvertNumbers(numberToConvert - 3999);
            if (numberToConvert >= 2014) return "MMXIV" + ConvertNumbers(numberToConvert - 2014);
            if (numberToConvert >= 1023) return "MXXIII" + ConvertNumbers(numberToConvert - 1023);
            if (numberToConvert >= 1006) return "MVI" + ConvertNumbers(numberToConvert - 1006);
            if (numberToConvert >= 1004) return "MIV" + ConvertNumbers(numberToConvert - 1004);
            if (numberToConvert >= 1000) return "M" + ConvertNumbers(numberToConvert - 1000);
            if (numberToConvert >= 891) return "DCCCXCI" + ConvertNumbers(numberToConvert - 891);
            if (numberToConvert >= 798) return "DCCXCVII" + ConvertNumbers(numberToConvert - 798);
            if (numberToConvert >= 649) return "DCXLIX" + ConvertNumbers(numberToConvert - 649);
            if (numberToConvert >= 501) return "DI" + ConvertNumbers(numberToConvert - 501);
            if (numberToConvert >= 500) return "D" + ConvertNumbers(numberToConvert - 500);
            if (numberToConvert >= 99) return "XCIX" + ConvertNumbers(numberToConvert - 99);
            if (numberToConvert >= 97) return "XCVII" + ConvertNumbers(numberToConvert - 97);
            if (numberToConvert >= 83) return "LXXXIII" + ConvertNumbers(numberToConvert - 83);
            if (numberToConvert >= 68) return "LXVIII" + ConvertNumbers(numberToConvert - 68);
            if (numberToConvert >= 45) return "XLV" + ConvertNumbers(numberToConvert - 45);
            if (numberToConvert >= 44) return "XLIV" + ConvertNumbers(numberToConvert - 44);
            if (numberToConvert >= 29) return "XXIX" + ConvertNumbers(numberToConvert - 29);
            if (numberToConvert >= 16) return "XVI" + ConvertNumbers(numberToConvert - 16);
            if (numberToConvert >= 12) return "XII" + ConvertNumbers(numberToConvert - 12);
            if (numberToConvert >= 9) return "IX" + ConvertNumbers(numberToConvert - 9);
            if (numberToConvert >= 5) return "V" + ConvertNumbers(numberToConvert - 5);
            if (numberToConvert >= 1) return "I" + ConvertNumbers(numberToConvert - 1);
            throw new ArgumentOutOfRangeException("Error");
        }
    }
}
