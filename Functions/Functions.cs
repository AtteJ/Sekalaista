using System;

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
        
        Console.WriteLine(GradualIncrease(addedAmount, decreaseFactor, iterations, amount));
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


    /// <summary>
    /// Skaalaa halutulle välille luvun samassa suhteessa kuin annettu luku
    /// </summary>
    /// <param name="luku">Luku väliltä 0 ja 1</param>
    /// <param name="alku">Haluttujen lukujen alku</param>
    /// <param name="loppu">Haluttujen lukujen loppu</param>
    /// <returns>Skaalattu luku halutulle välille</returns>
    /// <example>
    /// <pre name="test">
    ///  Scaler(0.1,0,10) ~~~ 1;
    ///  Scaler(1,1,6) ~~~ 6;
    ///  Scaler(0.5,1,4) ~~~ 2.5;
    ///  Scaler(0.2,-5,0) ~~~ -4;
    /// </pre>
    /// </example>
    public static double Scaler(double luku, int alku, int loppu)
    {
        return alku + (loppu - alku) * luku;
    }
}
