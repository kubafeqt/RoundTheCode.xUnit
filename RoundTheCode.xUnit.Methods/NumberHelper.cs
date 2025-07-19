using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundTheCode.xUnit.Methods
{
    public static class NumberHelper
    {
      public static bool IsOddNumber(int number)
      {
         return number % 2 == 1;
      }

      public static bool IsEvenNumber(int number)
      {
         return number % 2 == 0;
      }

      public static string RatingScore(int number) => number switch
      {
         < 0 => "Negative",
         0 => "Zero",
         < 3 => "Bad",
         >= 3 and < 7 => "Ok",
         >= 7 and <= 10 => "Great",
         _ => "Unknown"
      };

   }
}
