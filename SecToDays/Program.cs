using System.ComponentModel.Design;

namespace SecToDays
{
    /// <summary>
    /// Διαβάζει από το χρήστη δευτερόλεπτα και τα 
    /// μετατρέπει σε μέρες, ώρες, λεπτά και δευτερόλεπτα.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal inputSec = 0m;
            decimal seconds = 0m;
            decimal minutes = 0m;
            decimal hours = 0m;
            decimal days = 0m;
            int SEC_PER_MIN = 60;
            int SEC_PER_HOUR = 60 * SEC_PER_MIN;
            int SEC_PER_DAY = 24 * SEC_PER_HOUR;

            Console.WriteLine("Please insert seconds:");
            if(!decimal.TryParse(Console.ReadLine(), out inputSec) )
            {
                Console.WriteLine("Error in input!");
            }
            
            days = inputSec / SEC_PER_DAY;
            seconds = inputSec % SEC_PER_DAY;

            hours = inputSec / SEC_PER_HOUR;
            seconds = seconds % SEC_PER_HOUR;

            minutes = inputSec / SEC_PER_MIN;
            seconds = seconds % SEC_PER_MIN;

            Console.WriteLine($"Input seconds {inputSec} are equal to: \n " +
                $"{days:N0} days, {hours:N0} hours, {minutes:N0} minutes, {seconds:N0} seconds");

        }
    }
}
