using System;
using System.Collections.Generic;

namespace waltonstine.example.csharp.yield
{
    public class MainProgram
    {
        // Not really infinite - overflows Int64 in less than a thousand iterations.
        public static IEnumerable<Int64> infiniteFibonacci()
        {
            Int64 n2 = 0;
            Int64 n1 = 1;
            while (true)
            {
                Int64 fib = n1 + n2;
                yield return fib;
                n2 = n1;
                n1 = fib;
            }
        }

        // Bounded enumerable: the digits, 0 - 9.
        public static IEnumerable<int> digits()
        {
            for (int ii = 0; ii < 10; ii++)
            {
                yield return ii;
            }
        }

        public static void Main(string[] args)
        {
            const int LIMIT = 10;

            Console.WriteLine($"First {LIMIT} Fibonacci numbers: ");

            IEnumerator<Int64> fibEnumerator = infiniteFibonacci().GetEnumerator();
            int cnt = 0;

            while(true)
            {
                fibEnumerator.MoveNext();
                Console.WriteLine($"\t{fibEnumerator.Current}");
                if (++cnt >= LIMIT)
                {
                    break;
                }
            }

            Console.WriteLine($"{LIMIT} Digits: ");

            IEnumerator<int> digEnumerator = digits().GetEnumerator();
            
            while (digEnumerator.MoveNext() )
            {
                Console.WriteLine($"\t{digEnumerator.Current}");
            }

        }
    }
}
