using NUnit.Framework;
using System.Collections.Generic;

namespace Product_of_consecutive_Fib_numbers
{
    // The Fibonacci numbers are the numbers in the following integer sequence (Fn):
    // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ...
    // such as
    // F(n) = F(n-1) + F(n-2) with F(0) = 0 and F(1) = 1.
    // Given a number, say prod(for product), we search two Fibonacci numbers F(n) and F(n+1) verifying
    // F(n) * F(n+1) = prod.
    // Your function productFib takes an integer(prod) and returns an array:
    // [F(n), F(n + 1), true] or {F(n), F(n+1), 1} or (F(n), F(n + 1), True)
    // depending on the language if F(n) * F(n + 1) = prod.

    // If you don't find two consecutive F(m) verifying F(m) * F(m+1) = prod you will return
    // [F(m), F(m + 1), false] or {F(n), F(n + 1), 0} or (F(n), F(n + 1), False)
    // F(m) being the smallest one such as F(m) *F(m + 1) > prod.

    public class ProdFib
    {
        public static ulong[] productFib(ulong prod)
        {
            var fib = new List<ulong> { 0, 1 };

            for (int i = 0; i < 100; i++)
                fib.Add(fib[i] + fib[i + 1]);

            for (int i = 0; i + 1 < fib.Count; i++)
            {
                if (fib[i] * fib[i + 1] == prod)
                    return new ulong[] { fib[i], fib[i + 1], 1 };
                if (fib[i] * fib[i + 1] > prod)
                    return new ulong[] { fib[i], fib[i + 1], 0 };
            }
            return null;
        }
    }

    [TestFixture]
    public class ProdFibTests
    {

        [Test]
        public void Test1()
        {
            ulong[] r = new ulong[] { 55, 89, 1 };
            Assert.AreEqual(r, ProdFib.productFib(4895));
        }
    }
}