using System;
using System.IO;


namespace Blox
{

    class Program
    {
        static void Main(string[] args)
        {
            Variations variations = new Variations();
            IEnumerable<int> combination = new List<int>{0, 13, 9, 35, 27, 4, 30};
            variations.RotateCombination(combination);
        }

        private void CreateCSV()
        {
            string path = @"W:\Blox\Combinations.csv";

            int[][] dice = {
                    new[] { 0, 12, 18, 19, 25, 32 },   // A1, C1, D1, D2, E2, F3
                    new[] { 1, 7, 13, 4, 6, 8 },       // A2, B2 etc
                    new[] { 14, 20, 26, 9, 15, 21 },
                    new[] { 3, 10, 17, 16, 23, 35},
                    new[] { 27, 33, 28, 34, 22, 29},
                    new[] { 24, 31, 11, 4},
                    new[] { 30, 5}
                };
            var combinations = Algorithms.CartesianProduct(dice);

            Console.WriteLine("There are " + combinations.Count() + " possible combinations, writing to CSV.");

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Dice 1, Dice 2, Dice 3, Dice 4, Dice 5, Dice 6, Dice 7");
                    foreach (var combination in combinations)
                    {
                        sw.WriteLine(String.Join(", ", combination));
                    }
                }
            }
        }
    }
}