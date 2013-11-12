using System.Linq;
using Fibonacci;
using NUnit.Framework;

namespace FibonacciTests
{
    [TestFixture]
    class FibonacciTests
    {
        [Test]
        public void FibsReturnsTheFirst12ValuesCorrectly()
        {
            var fibonacciNumbers = JtEnumerable.Fibs().Take(12);
            Assert.That(fibonacciNumbers, Is.EqualTo(new[] {0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89}));
        }

        [Test]
        public void FibsOverflowsEventually()
        {
            // ReSharper disable ReturnValueOfPureMethodIsNotUsed
            Assert.Throws<System.OverflowException>(() => JtEnumerable.Fibs().Last());
            // ReSharper restore ReturnValueOfPureMethodIsNotUsed
        }

        [Test]
        public void FibsReturnsTheFirst93ValuesWithoutOverflowing()
        {
            var fibonacciNumbers = JtEnumerable.Fibs().Take(93);
            Assert.That(fibonacciNumbers, Is.All.GreaterThanOrEqualTo(0));
        }

        [Test]
        public void FibsOverflowsAtThe94ThValue()
        {
            // ReSharper disable ReturnValueOfPureMethodIsNotUsed
            Assert.Throws<System.OverflowException>(() => JtEnumerable.Fibs().Skip(93).First());
            // ReSharper restore ReturnValueOfPureMethodIsNotUsed
        }
    }
}
