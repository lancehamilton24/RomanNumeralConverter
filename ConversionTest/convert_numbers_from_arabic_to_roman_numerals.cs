using System;
using Xunit;

namespace RomanNumeralConverter.ConversionTest
{
    public class convert_numbers_from_arabic_to_roman_numerals
    {
        [Fact]
        public void converting_1_to_roman_should_result_I()
        {
            //Arrange -- Context              -- Given
            var converter = new ConversionEngine();
            var input = 2;
            var expectedOutput = "II";
            //Act     -- Do the thing         -- When
            var actualResult = converter.ConvertNumbers(input);
            //Assert  -- checking the result  -- Then
            Assert.Equal(expectedOutput, actualResult);
        }
    }
}
