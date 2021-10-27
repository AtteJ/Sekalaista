using System;
using System.Collections.Generic;

/// @author AtteJ
/// @version 15.10.
/// <summary>
/// Laskee ja listaa halutun maaran alkulukuja
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


    /// <summary>
	/// Kysyy kayttajalta kuinka monta alkulukua listataan ja tarkistaa onko syote kokonaisluku
	/// </summary>
	/// <returns>Kayttajan syottaman kokonaisluku</returns>
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


    /// <summary>
	/// Laskee alkulukuja ja listaa ne
	/// </summary>
	/// <param name="numbers">Kuinka monta alkulukua listataan</param>
	/// <returns>Lista, jossa on haluttu maara alkulukuja</returns>
    public static List<int> CalculatePrimeNumbers(int numbers)
    {
        int addedNumbers = 0;
        int i = 1;

        List<int> primeNumbers = new List<int>();
        
        while (addedNumbers <= numbers)
        {
            if (i == 1 || i == 3 || i == 5 || i == 7 || i == 11)
            {
                Console.WriteLine(i);
                addedNumbers++;
                i++;

                primeNumbers.Add(i);

                continue;
            }

            if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0 && i % 11 != 0)
            {
                Console.WriteLine(i);
                addedNumbers++;

                primeNumbers.Add(i);
            }

            i++;
        }

        return primeNumbers;
    }


    /// <summary>
	/// Laskee alkulukuja ja listaa ne
	/// </summary>
	/// <param name="numbers">Kuinka monta alkulukua listataan</param>
	/// <param name="startingPoint">Mista luvusta lahdetaan laskemaan</param>
	/// <returns>Lista, jossa on haluttu maara alkulukuja</returns>
    public static List<int> CalculatePrimeNumbers(int numbers, int startingPoint)
    {
        int addedNumbers = 0;
        int i = startingPoint;

        List<int> primeNumbers = new List<int>();

        while (addedNumbers <= numbers)
        {
            if (i == 1 || i == 3 || i == 5 || i == 7 || i == 11)
            {
                Console.WriteLine(i);
                addedNumbers++;
                i++;

                primeNumbers.Add(i);

                continue;
            }

            if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0 && i % 11 != 0)
            {
                Console.WriteLine(i);
                addedNumbers++;

                primeNumbers.Add(i);
            }

            i++;
        }

        return primeNumbers;
    }
}
