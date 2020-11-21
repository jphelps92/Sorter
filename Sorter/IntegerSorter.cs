using System.Collections.Generic;

namespace Sorter
{
    public class IntegerSorter
    {
        /// <summary>
        /// Reverses pairs of numbers. For instance: 17 becomes 71 and 1234 become 2143.
        /// If there are on odd number of numbers, the last one is left alone.
        /// For instance: 123 becomes 213.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int Sort(int input)
        {
            // todo - there's gotta be a better way to do this
            var numberList = new List<int>();
            foreach (var character in input.ToString())
            {
                numberList.Add(int.Parse(character.ToString()));
            }

            for (int i = 0; i < numberList.Count -1; i+= 2)
            {
                var temp = numberList[i];
                numberList[i] = numberList[i + 1];
                numberList[i + 1] = temp;
            }

            var outputString = string.Empty;
            foreach (var stuff in numberList)
            {
                outputString += stuff;
            }

            return int.Parse(outputString);
        }
    }
}
