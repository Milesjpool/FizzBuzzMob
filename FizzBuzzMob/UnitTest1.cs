using System;
using NUnit.Framework;

namespace FizzBuzzMob
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [TestCase(1,"1")]
        [TestCase(2,"1,2")]
        [TestCase(3,"1,2,Fizz")]
        [TestCase(4,"1,2,Fizz,4")]
        [TestCase(5,"1,2,Fizz,4,Buzz")]
        public void CalculatorReturns1(int input,string expectedResult)
        {
            string result = FizzBuzzCalculator.Calculate(input);
            Assert.That(result, Is.EqualTo(expectedResult));
        } 
        

    }

    public class FizzBuzzCalculator
    {
        public static string Calculate(int limit)
        {
            var result = "";

            for (int i = 1; i <= limit; i++,result+=",")
            {
                if (i == 3) result += "Fizz";
                else if (i == 5) result += "Buzz";
                else result += (i);
            }

            return result.Substring(0,result.Length-1);
        }
    }
}
