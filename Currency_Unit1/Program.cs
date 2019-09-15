using System;
using System.Globalization;
using System.Threading;

namespace Currency_Unit1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare Variables
            double dollar1;
            double dollar2;
            double dollar3;

            double total;
            double average;
            double max;
            double min;

            // Get User Input
            Console.Write("Please Enter a Dollar Amount: $");
            dollar1 = double.Parse(Console.ReadLine());

            Console.Write("Please Enter Another Dollar Amount: $");
            dollar2 = double.Parse(Console.ReadLine());

            Console.Write("Please Enter Another Dollar Amount: $");
            dollar3 = double.Parse(Console.ReadLine());


            // Get Total
            total = (dollar1 + dollar2 + dollar3);

            // Get Average
            average = ((dollar1 + dollar2 + dollar3) / 3);

            // Get Max
            max = Math.Max(dollar1, Math.Max(dollar2, dollar3));

            // Get Min
            min = Math.Min(dollar1, Math.Min(dollar2, dollar3));


            // Display Output
            Console.WriteLine("The Total is:  $" + total.ToString("#,0.00"));
            Console.WriteLine("The Average is:  $" + average.ToString("#,0.00"));
            Console.WriteLine("The Max is:  $" + max.ToString("#,0.00"));
            Console.WriteLine("The Min is:  $" + min.ToString("#,0.00"));


            // Display Converted Totals in US, Swedish, Jap, and Thai
            Console.WriteLine("The Total in US is:  " + total.ToString("C2", CultureInfo.CreateSpecificCulture("en-us")));
            Console.WriteLine("The Total in SE is:  " + total.ToString("C2", CultureInfo.CreateSpecificCulture("sv-se")));
            Console.WriteLine("The Total in JP is:  " + total.ToString("C", CultureInfo.CreateSpecificCulture("ja-jp")));
            Console.WriteLine("The Total in TH is:  " + total.ToString("C2", CultureInfo.CreateSpecificCulture("th-th")));

            Thread.Sleep(5000);
        }
    }
}