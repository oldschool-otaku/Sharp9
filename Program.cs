using System;
using System.Collections.Generic;

namespace Sharp9
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine(Tasks.GetDigits(out List<int> numbers));
        }
    }
}