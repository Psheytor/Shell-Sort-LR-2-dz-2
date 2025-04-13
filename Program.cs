using System;
using System.Collections.Generic;

public class TurtleSort
{
    public static void Main()
    {
        int K = int.Parse(Console.ReadLine()!);

        for (int testCase = 0; testCase < K; testCase++)
        {
            if (testCase > 0)
                Console.WriteLine();
            int n = int.Parse(Console.ReadLine()!);

            string[] initialOrder = new string[n];
            for (int i = 0; i < n; i++)
                initialOrder[i] = Console.ReadLine()!;

            string[] desiredOrder = new string[n];
            for (int i = 0; i < n; i++)
                desiredOrder[i] = Console.ReadLine()!;

            var moves = FindTurtleMoves(initialOrder, desiredOrder);// последовательность перемещений

            foreach (var move in moves)
                Console.WriteLine(move);
        }
    }
    private static List<string> FindTurtleMoves(string[] initial, string[] desired)
    {
        List<string> moves = new List<string>();
        int n = initial.Length;
        int desiredPos = n - 1;
        int currentPos = n - 1;

        while (desiredPos >= 0)
        {
            if (initial[currentPos] == desired[desiredPos])//поиск текущей черепахи в исходном порядке
            {
                desiredPos--;
                currentPos--;
            }
            else
            {
                moves.Add(desired[desiredPos]);//добавляем черепаху в список перемещений
                desiredPos--;
            }
        }
        return moves;
    }
}

