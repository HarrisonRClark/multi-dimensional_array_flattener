using System.Linq;

namespace Blox
{
    public class Variations
    {
        private int[] outerCircle = new int[20]
        {
            0, 1, 2, 3, 4, 5, 11, 17, 23, 29, 35, 34, 33, 32, 31, 30, 24, 18, 12, 6
        };

        private int[] middleCircle = new int[12]
        {
            7, 8, 9, 10, 16, 22, 28, 27, 26, 25, 19, 13
        };

        private int[] innerCircle = new int[4]
        {
            14, 15, 20, 21
        };
        public IEnumerable<int> RotateCombination(IEnumerable<int> combination)
        {

            List<int> output = new List<int>();
            foreach (int number in combination)
            {
                if (outerCircle.Contains(number))
                {
                    int initIndex = Array.FindIndex(outerCircle, element => element == number);
                    int newIndex = initIndex + 5;
                    if (newIndex >= outerCircle.Length)
                    {
                        newIndex -= outerCircle.Length;
                    }
                    // Console.WriteLine(number.ToString() + " is within the outer circle at index: " + initIndex + ", which becomes index: " + newIndex);
                    output.Add(outerCircle[newIndex]);
                }
                else if (middleCircle.Contains(number))
                {
                    int initIndex = Array.FindIndex(middleCircle, element => element == number);
                    int newIndex = initIndex + 3;
                    if (newIndex >= middleCircle.Length)
                    {
                        newIndex -= middleCircle.Length;
                    }
                    // Console.WriteLine(number.ToString() + " is within the middle circle at index: " + initIndex + ", which becomes index: " + newIndex);
                    output.Add(middleCircle[newIndex]);

                }
                else if (innerCircle.Contains(number))
                {
                    int initIndex = Array.FindIndex(innerCircle, element => element == number);
                    int newIndex = initIndex + 1;
                    if (newIndex >= innerCircle.Length)
                    {
                        newIndex -= innerCircle.Length;
                    }
                    // Console.WriteLine(number.ToString() + " is within the inner circle at index: " + initIndex + ", which becomes index: " + newIndex);
                    output.Add(innerCircle[newIndex]);
                }
            }
            // Console.WriteLine("The original array of: " + string.Join(", ", combination) + " has been rotated to make: " + string.Join(", ", output));
            return output;
        }
    }

}