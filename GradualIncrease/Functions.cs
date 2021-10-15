using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

/// @author Omanimi
/// @version Päivämäärä
/// <summary>
/// Useful short functions for various uses 
/// </summary>
public class Functions
{
    /// <summary>
    /// Calculates addition after decreasing by a factor. E.g. adding 25ml juice concentrate to water glass after drinking 25%. 
    /// </summary>
    public static void Main()
    {
        double addedAmount = 25;
        double decreaseFactor = 0.75;
        double iterations = 5;
        double amount = 25;
        
        System.Console.WriteLine(GradualIncrease(addedAmount, decreaseFactor, iterations, amount));
    }

    /// <summary>
    /// Calculates addition after decreasing by a factor. E.g. adding 25ml juice concentrate to water glass after drinking 25%.
    /// </summary>
    /// <param name="addedAmount">How much is added each iterarions</param>
    /// <param name="decreaseFactor">How much the return value is multiplied each iterations</param>
    /// <param name="iterations">How many times the calculation is run</param>
    /// <param name="beginningAmount">What is the starting amount</param>
    /// <returns>Beginning amount first multiplied by factor and then added by addedAmount run once or multiple times.</returns>
    public static double GradualIncrease(double addedAmount, double decreaseFactor, double iterations, double beginningAmount)
    {
        for (int i = 0; i < iterations; i++)
        {
            beginningAmount *= decreaseFactor;
            beginningAmount += addedAmount;
        }

        return beginningAmount;
    }
}
