namespace DaysToSec
{
    /// <summary>
    /// Διαβάζει από το χρήστη μέρες, ώρες, λεπτά
    /// και δευτερόλεπτα και τυπώνει τα συνολικά δευτερόλεπτα. 
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int SEC_PER_MIN = 60;
            int SEC_PER_HOUR = 60 * SEC_PER_MIN;
            int SEC_PER_DAY = 24 * SEC_PER_HOUR;
            decimal seconds = 0m;

            Console.WriteLine("Please insert days, hours, minutes, seconds:");
            if (!decimal.TryParse(Console.ReadLine(), out decimal inputDays))
            {
                Console.WriteLine("Error in input!");
            }
            if (!decimal.TryParse(Console.ReadLine(), out decimal inputHours))
            {
                Console.WriteLine("Error in input!");
            }
            if (!decimal.TryParse(Console.ReadLine(), out decimal inputMin))
            {
                Console.WriteLine("Error in input!");
            }
            if (!decimal.TryParse(Console.ReadLine(), out decimal inputSec))
            {
                Console.WriteLine("Error in input!");
            }


            seconds = inputDays * SEC_PER_DAY + inputHours * SEC_PER_HOUR + inputMin * SEC_PER_MIN + inputSec; 

            Console.WriteLine($"Input {inputDays:N0} days, {inputHours:N0} hours, {inputMin:N0} minutes, {inputSec:N0} seconds" +
                $" are equal to: \n {seconds:N2} total seconds");
        }
    }
}
