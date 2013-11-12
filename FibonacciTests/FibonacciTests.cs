using System.Linq;
using Fibonacci;
using NUnit.Framework;

namespace FibonacciTests
{
    [TestFixture]
    class FibonacciTests
    {
        [Test]
        public void TestFibsReturnsTheCorrectFirstTwelveValuesInTheSequence()
        {
            var fibonacciNumbers = JtEnumerable.Fibs().Take(12);
            Assert.That(fibonacciNumbers, Is.EqualTo(new[] {0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89}));
        }

        [Test]
        public void TestFibsDoesNotWrapAroundForTheFirstNinetyThreeValuesInTheSequence()
        {
            var fibonacciNumbers = JtEnumerable.Fibs().Take(93).ToList();
            Assert.That(fibonacciNumbers, Is.All.GreaterThanOrEqualTo(0));
        }

        [Test]
        public void TestFibsDoesWrapAroundAtTheNinetyFourthValueInTheSequence()
        {
            var fibonacciNumbers = JtEnumerable.Fibs().Take(94).ToList();
            Assert.That(fibonacciNumbers.Take(93), Is.All.GreaterThanOrEqualTo(0));
            Assert.That(fibonacciNumbers.ElementAt(93), Is.LessThan(0));
        }
    }
}
