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
        [Fact]
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
        [Fact]
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
        [Fact]
        public void converting_12_to_roman_should_result_XII()
        {
            //Arrange -- Context              -- Given
            var converter = new ConversionEngine();
        var input = 12;
        var expectedOutput = "XII";
        //Act     -- Do the thing         -- When
        var actualResult = converter.ConvertNumbers(input);
        //Assert  -- checking the result  -- Then
        Assert.Equal(expectedOutput, actualResult);
        }
        [Fact]
        public void converting_16_to_roman_should_result_XVI()
        {
            //Arrange -- Context              -- Given
            var converter = new ConversionEngine();
        var input = 16;
        var expectedOutput = "XVI";
        //Act     -- Do the thing         -- When
        var actualResult = converter.ConvertNumbers(input);
        //Assert  -- checking the result  -- Then
        Assert.Equal(expectedOutput, actualResult);
        }
        [Fact]
        public void converting_29_to_roman_should_result_XXIX()
        {
            //Arrange -- Context              -- Given
            var converter = new ConversionEngine();
            var input = 29;
            var expectedOutput = "XXIX";
            //Act     -- Do the thing         -- When
            var actualResult = converter.ConvertNumbers(input);
            //Assert  -- checking the result  -- Then
            Assert.Equal(expectedOutput, actualResult);
        }
        [Fact]
        public void converting_44_to_roman_should_result_XLIV()
        {
            //Arrange -- Context              -- Given
            var converter = new ConversionEngine();
            var input = 44;
            var expectedOutput = "XLIV";
            //Act     -- Do the thing         -- When
            var actualResult = converter.ConvertNumbers(input);
            //Assert  -- checking the result  -- Then
            Assert.Equal(expectedOutput, actualResult);
        }
        [Fact]
        public void converting_45_to_roman_should_result_XLV()
        {
            //Arrange -- Context              -- Given
            var converter = new ConversionEngine();
            var input = 45;
            var expectedOutput = "XLV";
            //Act     -- Do the thing         -- When
            var actualResult = converter.ConvertNumbers(input);
            //Assert  -- checking the result  -- Then
            Assert.Equal(expectedOutput, actualResult);
        }
        [Fact]
        public void converting_68_to_roman_should_result_LXVIII()
        {
            //Arrange -- Context              -- Given
            var converter = new ConversionEngine();
            var input = 68;
            var expectedOutput = "LXVIII";
            //Act     -- Do the thing         -- When
            var actualResult = converter.ConvertNumbers(input);
            //Assert  -- checking the result  -- Then
            Assert.Equal(expectedOutput, actualResult);
        }
        [Fact]
        public void converting_83_to_roman_should_result_LXXXIII()
        {
            //Arrange -- Context              -- Given
            var converter = new ConversionEngine();
            var input = 83;
            var expectedOutput = "LXXXIII";
            //Act     -- Do the thing         -- When
            var actualResult = converter.ConvertNumbers(input);
            //Assert  -- checking the result  -- Then
            Assert.Equal(expectedOutput, actualResult);
        }
        [Fact]
        public void converting_97_to_roman_should_result_XCVII()
        {
            //Arrange -- Context              -- Given
            var converter = new ConversionEngine();
            var input = 97;
            var expectedOutput = "XCVII";
            //Act     -- Do the thing         -- When
            var actualResult = converter.ConvertNumbers(input);
            //Assert  -- checking the result  -- Then
            Assert.Equal(expectedOutput, actualResult);
        }
        [Fact]
        public void converting_99_to_roman_should_result_XCIX()
        {
            //Arrange -- Context              -- Given
            var converter = new ConversionEngine();
            var input = 99;
            var expectedOutput = "XCIX";
            //Act     -- Do the thing         -- When
            var actualResult = converter.ConvertNumbers(input);
            //Assert  -- checking the result  -- Then
            Assert.Equal(expectedOutput, actualResult);
        }
        [Fact]
        public void converting_500_to_roman_should_result_D()
        {
            //Arrange -- Context              -- Given
            var converter = new ConversionEngine();
            var input = 500;
            var expectedOutput = "D";
            //Act     -- Do the thing         -- When
            var actualResult = converter.ConvertNumbers(input);
            //Assert  -- checking the result  -- Then
            Assert.Equal(expectedOutput, actualResult);
        }
        [Fact]
        public void converting_501_to_roman_should_result_DI()
        {
            //Arrange -- Context              -- Given
            var converter = new ConversionEngine();
            var input = 501;
            var expectedOutput = "DI";
            //Act     -- Do the thing         -- When
            var actualResult = converter.ConvertNumbers(input);
            //Assert  -- checking the result  -- Then
            Assert.Equal(expectedOutput, actualResult);
        }
        [Fact]
        public void converting_649_to_roman_should_result_DCXLIX()
        {
            //Arrange -- Context              -- Given
            var converter = new ConversionEngine();
            var input = 649;
            var expectedOutput = "DCXLIX";
            //Act     -- Do the thing         -- When
            var actualResult = converter.ConvertNumbers(input);
            //Assert  -- checking the result  -- Then
            Assert.Equal(expectedOutput, actualResult);
        }
        [Fact]
        public void converting_798_to_roman_should_result_DCCXCVII()
        {
            //Arrange -- Context              -- Given
            var converter = new ConversionEngine();
            var input = 798;
            var expectedOutput = "DCCXCVII";
            //Act     -- Do the thing         -- When
            var actualResult = converter.ConvertNumbers(input);
            //Assert  -- checking the result  -- Then
            Assert.Equal(expectedOutput, actualResult);
        }
        [Fact]
        public void converting_891_to_roman_should_result_DCCCXCI()
        {
            //Arrange -- Context              -- Given
            var converter = new ConversionEngine();
            var input = 891;
            var expectedOutput = "DCCCXCI";
            //Act     -- Do the thing         -- When
            var actualResult = converter.ConvertNumbers(input);
            //Assert  -- checking the result  -- Then
            Assert.Equal(expectedOutput, actualResult);
        }
        [Fact]
        public void converting_1000_to_roman_should_result_M()
        {
            //Arrange -- Context              -- Given
            var converter = new ConversionEngine();
            var input = 1000;
            var expectedOutput = "M";
            //Act     -- Do the thing         -- When
            var actualResult = converter.ConvertNumbers(input);
            //Assert  -- checking the result  -- Then
            Assert.Equal(expectedOutput, actualResult);
        }
        [Fact]
        public void converting_1004_to_roman_should_result_MIV()
        {
            //Arrange -- Context              -- Given
            var converter = new ConversionEngine();
            var input = 1004;
            var expectedOutput = "MIV";
            //Act     -- Do the thing         -- When
            var actualResult = converter.ConvertNumbers(input);
            //Assert  -- checking the result  -- Then
            Assert.Equal(expectedOutput, actualResult);
        }
        [Fact]
        public void converting_1006_to_roman_should_result_MVI()
        {
            //Arrange -- Context              -- Given
            var converter = new ConversionEngine();
            var input = 1006;
            var expectedOutput = "MVI";
            //Act     -- Do the thing         -- When
            var actualResult = converter.ConvertNumbers(input);
            //Assert  -- checking the result  -- Then
            Assert.Equal(expectedOutput, actualResult);
        }
        [Fact]
        public void converting_1023_to_roman_should_result_MXXIII()
        {
            //Arrange -- Context              -- Given
            var converter = new ConversionEngine();
            var input = 1023;
            var expectedOutput = "MXXIII";
            //Act     -- Do the thing         -- When
            var actualResult = converter.ConvertNumbers(input);
            //Assert  -- checking the result  -- Then
            Assert.Equal(expectedOutput, actualResult);
        }
        [Fact]
        public void converting_2014_to_roman_should_result_MMXIV()
        {
            //Arrange -- Context              -- Given
            var converter = new ConversionEngine();
            var input = 2014;
            var expectedOutput = "MMXIV";
            //Act     -- Do the thing         -- When
            var actualResult = converter.ConvertNumbers(input);
            //Assert  -- checking the result  -- Then
            Assert.Equal(expectedOutput, actualResult);
        }
        [Fact]
        public void converting_3999_to_roman_should_result_MMMCMX()
        {
            //Arrange -- Context              -- Given
            var converter = new ConversionEngine();
            var input = 3999;
            var expectedOutput = "MMMCMX";
            //Act     -- Do the thing         -- When
            var actualResult = converter.ConvertNumbers(input);
            //Assert  -- checking the result  -- Then
            Assert.Equal(expectedOutput, actualResult);
        }
    }
}
