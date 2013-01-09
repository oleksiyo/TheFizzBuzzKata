using ApprovalTests;
using ApprovalTests.Reporters;
using Xunit;

namespace TheFizzBuzzKata
{
    public class FizzBuzzTest
    {
        private FizzBuzz fizzBuzz;

        public FizzBuzzTest()
        {
            fizzBuzz = new FizzBuzz();
        }

        [Fact]
        public void should_return_numbers_from_1_to_100()
        {
            fizzBuzz.PrintNumbers();
        }

        [Fact]
        [UseReporter(typeof(DiffReporter))]
        public void should_be_print_Fizz_if_number_divisible_by_three()
        {
            var result = fizzBuzz.PrintNumbers();
            Approvals.Verify(result);
        }

        [Fact]
        [UseReporter(typeof(DiffReporter))]
        public void should_be_print_Buzz_for_divisible_by_five_and_Fizz_for_three()
        {
            var result = fizzBuzz.PrintNumbers();
            Approvals.Verify(result);
        }
    }
}