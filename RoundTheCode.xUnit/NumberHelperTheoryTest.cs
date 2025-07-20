using RoundTheCode.xUnit.Methods;

namespace RoundTheCode.xUnit
{
   public class NumberHelperTheoryTest
   {
      [Theory]
      [InlineData(3)]
      [InlineData(5)]
      [InlineData(7)]
      public void IsOddNumber_ShouldReturnTrue(int number)
      {
         Assert.True(NumberHelper.IsOddNumber(number));
      }

      [Theory]
      [InlineData(2)]
      [InlineData(4)]
      [InlineData(6)]
      public void IsOddNumber_ShouldReturnFalse(int number)
      {
         Assert.False(NumberHelper.IsOddNumber(number));
      }

      [Theory]
      [InlineData(3)]
      [InlineData(5)]
      [InlineData(7)]
      public void IsEvenNumber_ShouldReturnFalse(int number)
      {
         Assert.False(NumberHelper.IsEvenNumber(number));
      }

      [Theory]
      [InlineData(2)]
      [InlineData(4)]
      [InlineData(6)]
      public void IsEvenNumber_ShouldReturnTrue(int number)
      {
         Assert.True(NumberHelper.IsEvenNumber(number));
      }

      [Theory]
      [InlineData(-1, "Negative")]
      [InlineData(0, "Zero")]
      [InlineData(8, "Great")]
      [InlineData(2, "Bad")]
      [InlineData(5, "Ok")]
      [InlineData(11, "Unknown")]
      public void RatingScore_Values_EqualCorrectRating(int number, string expectedRating)
      {
         Assert.Equal(expectedRating, NumberHelper.RatingScore(number));
      }



   }
}
