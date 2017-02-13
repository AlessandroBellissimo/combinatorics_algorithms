using System;
using System.Collections.Generic;

namespace TestCombinatorics
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] A = { 1, 2, 3, 4, 5 };
            List<string> S = Combinatorics.CombinationsWithoutRepetition(A);
            foreach (string s in S)
                Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}