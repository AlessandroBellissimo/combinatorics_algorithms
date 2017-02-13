using System.Collections.Generic;

namespace TestCombinatorics
{
    public static class Combinatorics
    {
        public static List<string> PlacementsWithoutRepetition(int[] A)
        {
            int N = A.Length;
            List<string> s = new List<string>();
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                {
                    if (i == j) continue;
                    s.Add(A[i] + " " + A[j]);
                }
            return s;
        }

        public static List<string> PlacementsWithRepetition(int[] A)
        {
            int N = A.Length;
            List<string> s = new List<string>();
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                {
                    s.Add(A[i] + " " + A[j]);
                }
            return s;
        }

        public static List<string> CombinationsWithoutRepetition(int[] A)
        {
            int N = A.Length;
            List<string> s = new List<string>();
            for (int i = 0; i < N - 1; i++)
                for (int j = i + 1; j < N; j++)
                {
                    if (i != j) s.Add(A[i] + " " + A[j]);
                }
            return s;
        }

        public static List<string> CombinationsWithRepetition(int[] A)
        {
            int N = A.Length;
            List<string> s = new List<string>();
            for (int i = 0; i < N; i++)
                for (int j = i; j < N; j++)
                {
                    s.Add(A[i] + " " + A[j]);
                }
            return s;
        }
    }
}