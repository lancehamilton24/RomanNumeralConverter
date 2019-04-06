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
            var input = 1;
            var expectedOutput = "I";
            //Act     -- Do the thing         -- When
            var actualResult = converter.ConvertNumbers(input);
            //Assert  -- checking the result  -- Then
            Assert.Equal(expectedOutput, actualResult);
        }
        public void converting_5_to_roman_should_result_V()
        {
            //Arrange -- Context              -- Given
            var converter = new ConversionEngine();
            var input = 5;
            var expectedOutput = "V";
            //Act     -- Do the thing         -- When
            var actualResult = converter.ConvertNumbers(input);
            //Assert  -- checking the result  -- Then
            Assert.Equal(expectedOutput, actualResult);
        }
        public void converting_9_to_roman_should_result_IX()
        {
            //Arrange -- Context              -- Given
            var converter = new ConversionEngine();
            var input = 9;
            var expectedOutput = "IX";
            //Act     -- Do the thing         -- When
            var actualResult = converter.ConvertNumbers(input);
            //Assert  -- checking the result  -- Then
            Assert.Equal(expectedOutput, actualResult);
        }
    }
}
