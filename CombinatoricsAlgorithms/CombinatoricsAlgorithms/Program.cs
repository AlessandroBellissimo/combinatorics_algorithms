using System;
using System.Collections.Generic;

namespace TestCombinatorics
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
            Console.ReadKey();
        }

        private void Run()
        {
            Console.WriteLine("Введите количество элементов: ");
            int N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            Console.WriteLine("Введите элементы: ");
            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Сочетания без повторений: ");
            List<string> S = Combinatorics.CombinationsWithoutRepetition(A);
            foreach (string s in S)
                Console.WriteLine(s);
            Console.WriteLine("Количество сочетаний без повторений: {0}", S.Count);
        }
    }
}