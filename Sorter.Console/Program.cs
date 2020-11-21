namespace Sorter.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter a number of your choice: ");
            var input = System.Console.ReadLine();

            try
            {
                var result = IntegerSorter.Sort(int.Parse(input));

                System.Console.WriteLine($"Your number was {input} and we turned it into {result}");
            }
            catch
            {
                System.Console.WriteLine("You entered something that wasn't a number.");
            }
        }
    }
}
