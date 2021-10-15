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
        while (true)
        {
            int numberAmount = AskForNumber();
            if (numberAmount >= 0)
            {
                CalculatePrimeNumbers(numberAmount);
                break;
            }
            
            Console.WriteLine("Wasn't a positive whole number, try again");
        }


    }


    public static int AskForNumber()
    {
        Console.Write("How many prime numbers are printed? ");
        string numberAmount = Console.ReadLine();

        Console.WriteLine();
        
        if (int.TryParse(numberAmount, out int value))
        {
            return Int32.Parse(numberAmount);
        }

        return -1;
    }

    public static void CalculatePrimeNumbers(int numbers)
    {
        int addedNumbers = 0;
        int i = 1;
        
        while (addedNumbers <= numbers)
        {
            if (i == 1 || i == 3 || i == 5 || i == 7 || i == 11)
            {
                Console.WriteLine(i);
                addedNumbers++;
                i++;
                continue;
            }

            if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0 && i % 11 != 0)
            {
                Console.WriteLine(i);
                addedNumbers++;
            }

            i++;
        }
    }
}
