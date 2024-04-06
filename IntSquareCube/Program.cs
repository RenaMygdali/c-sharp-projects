namespace IntSquareCube
{
    /// <summary>
    /// Διαβάζει από τον χρήστη έναν ακέραιο
    /// και τον εμφανίζει μαζί με το τετράγωνο
    /// και τον κύβο του.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            double square = 0;
            double cube = 0;

            Console.WriteLine("Please insert an integer number:");
            if(!int.TryParse(Console.ReadLine(), out int inputInt)) 
            {
                Console.WriteLine("Error in input!");
                Environment.Exit(1);
            }

            square = Math.Pow(inputInt, 2);
            cube = Math.Pow(inputInt, 3);

            Console.WriteLine($"The square of {inputInt} is {inputInt}^2 = {square}.\n" +
                $"The cube of {inputInt} is {inputInt}^3 = {cube}");
        }
    }
}
