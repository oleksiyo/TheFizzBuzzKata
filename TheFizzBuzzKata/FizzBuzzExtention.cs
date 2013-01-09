using System;

namespace TheFizzBuzzKata
{
    public static class FizzBuzzExtention
    {
        public static TResult With<TInput, TResult>(this TInput o, Func<TInput, TResult> evaluator)
            where TResult : class
            where TInput : class
        {
            if (o == null) return null;
            return evaluator(o);
        }

        public static TResult ValidateDigit<TInput, TResult>(this TInput o, Func<TInput, TResult> evaluator)
            where TResult : class
            where TInput : struct 
        {
            return evaluator(o);
        }
    }
}