using System;
using Xunit;

namespace RomanNumeralConverter.ConversionTest
{
    public class convert_numbers_from_arabic_to_roman_numerals
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(5, "V")]
        [InlineData(9, "IX")]
        [InlineData(12, "XII")]
        [InlineData(16, "XVI")]
        [InlineData(29, "XXIX")]
        [InlineData(44, "XLIV")]
        [InlineData(45, "XLV")]
        [InlineData(68, "LXVIII")]
        [InlineData(83, "LXXXIII")]
        [InlineData(97, "XCVII")]
        [InlineData(99, "XCIX")]
        [InlineData(500, "D")]
        [InlineData(501, "DI")]
        [InlineData(649, "DCXLIX")]
        [InlineData(798, "DCCXCVII")]
        [InlineData(891, "DCCCXCI")]
        [InlineData(1000, "M")]
        [InlineData(1004, "MIV")]
        [InlineData(1006, "MVI")]
        [InlineData(1023, "MXXIII")]
        [InlineData(2014, "MMXIV")]
        [InlineData(3999, "MMMCMX")]
        public void converting_all_numbers_from_arabic_to_roman(int input, string expectedOutput)
        {
            //Arrange -- Context              -- Given
            var converter = new ConversionEngine();
            //Act     -- Do the thing         -- When
            var actualResult = converter.ConvertNumbers(input);
            //Assert  -- checking the result  -- Then
            Assert.Equal(expectedOutput, actualResult);
        }
    }
}
