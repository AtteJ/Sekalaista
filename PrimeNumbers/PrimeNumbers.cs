using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

/// @author Omanimi
/// @version Päivämäärä
/// <summary>
/// 
/// </summary>
public class PrimeNumbers
{
    /// <summary>
    /// Listaa halutun maaran alkulukuja
    /// </summary>
    public static void Main()
    {
        Console.Write("How many prime numbers are printed? ");
        int numberAmount = Int32.Parse(Console.ReadLine());

        CalculatePrimeNumbers(numberAmount);
    }


    public static void CalculatePrimeNumbers(int numbers)
    {
        for (int i = 0; i < numbers; i++)
        {
            if (i == 1 || i == 3 || i == 5 || i == 7)
            {
                Console.WriteLine(i);
                continue;
            }
            if (i%2 != 0 && i%3 != 0 && i%5 != 0 && i%7 != 0) Console.WriteLine(i);
        }
    }
}
