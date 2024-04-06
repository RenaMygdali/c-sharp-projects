using System.Text;

namespace EurosToDollars
{
    /// <summary>
    /// Διαβάζει από το χρήστη ένα ποσό σε Ευρώ
    /// και το μετατρέπει σε δολάρια USA.
    /// Η ισοτιμία είναι 1 Eυρώ = 116 USA cents.
    /// 
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            const int CENTS_PER_DOLLAR = 100;
            const decimal PARITY_IN_CENTS = 116m;
            decimal USDollars = 0m;
            decimal inputEuros = 0m;


            Console.WriteLine("Please insert an amount in Euros:");
            if (!decimal.TryParse(Console.ReadLine(), out inputEuros))
            {
                Console.WriteLine("Error in input!");
            }
            USDollars = inputEuros * (PARITY_IN_CENTS / CENTS_PER_DOLLAR);
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"Euros: {inputEuros}\u20AC, US Dollars: {USDollars:N2}\u0024");
        }
    }
}
