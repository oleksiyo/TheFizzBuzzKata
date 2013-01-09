using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApprovalTests;
using ApprovalTests.Reporters;
using Xunit;

namespace TheFizzBuzzKata
{
    public class FizzBuzz
    {
        private string DivisibleThree = "Fizz";
        private string DivisibleFive = "Buzz";

        public string PrintNumbers()
        {
            return string.Join(" ", GetFizzBuzzDigits());
        }

        private List<string> GetFizzBuzzDigits()
        {
            var results = new List<string>();
            var list = GenerateNumbers(1, 100);
            list.ForEach(x =>
                             {
                                 results.Add("");
                                 string result = string.Empty;
                                 if (x % 3 == 0)
                                     result = DivisibleThree;
                                 if (x % 5 == 0)
                                     result += DivisibleFive;
                                 else
                                     result = x.ToString();
                                 results.Add(result);
                             });
            return results;
        }

        private List<int> GenerateNumbers(int start, int end)
        {
            return Enumerable.Range(start, end).ToList();
        }

        private bool IsDivisibleThree(int digit)
        {
            return digit % 3 == 0;
        }
        private bool IsDivisibleFive(int digit)
        {
            return digit % 5 == 0;
        } 
    }
}
