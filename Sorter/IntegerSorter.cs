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
            var charArray = input.ToString().ToCharArray();
            for (int i = 0; i < charArray.Length - 1; i += 2)
            {
                var temp = charArray[i];
                charArray[i] = charArray[i + 1];
                charArray[i + 1] = temp;
            }

            return int.Parse(new string(charArray));
        }
    }
}
