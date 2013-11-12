using System.Collections.Generic;

namespace Fibonacci
{
    public static class JtEnumerable
    {
        // ReSharper disable FunctionNeverReturns
        public static IEnumerable<long> Fibs()
        {
            var lastButOne = 0L;
            var last = 1L;

            for (var n = 0L;; n++)
                checked
                {
                    if (n < 2) yield return n;
                    var next = lastButOne + last;
                    lastButOne = last;
                    last = next;
                    yield return next;
                }
        }
        // ReSharper restore FunctionNeverReturns
    }
}
