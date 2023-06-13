using System;
namespace MySolutions
{
    public class Swap
    {
        //Create a function that swaps the values of two variables within themselves
        public static void VariablSwap()
        {
            string carbrand = "Bugatti";
            string model = "Chiron";
            string car = carbrand;
            carbrand = model;
            model = car;

            Console.WriteLine(carbrand);
        }
    }
}