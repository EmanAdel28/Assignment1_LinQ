using System.Security.Cryptography;
using static Assignment1_LinQ.ListGenerator;
namespace Assignment1_LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Data Setup
            //foreach (var product in ProductList)
            //{
            //    Console.WriteLine(product);
            //}

            //foreach (var customer in CustomerList)
            //{
            //    Console.WriteLine($"{customer}  \n");
            //}
            #endregion

            #region LINQ - Restriction Operators
            #region Q1
            //1. Find all products that are out of stock.
            //var prouducts = from P in ProductList
            //                where P.UnitsInStock == 0
            //                select P;

            //foreach (var product in prouducts)
            //{
            //    Console.WriteLine(product);
            //}

            #endregion

            #region Q2
            //2. Find all products that are in stock and cost more than 3.00 per unit.
            //var prouducts = from P in ProductList
            //                where P.UnitsInStock > 0 && P.UnitPrice > 3
            //                select P;

            //foreach (var product in prouducts)
            //{
            //    Console.WriteLine(product);
            //}

            #endregion

            #region Q3
            //3. Returns digits whose name is shorter than their value.
            String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var shortNameDigits = Arr
            .Select((name, index) => new { Name = name, Value = index })
            .Where(digit => digit.Name.Length < digit.Value)
            .Select(digit => digit.Name);

            foreach (var digit in shortNameDigits)
            {
                Console.WriteLine(digit);
            }
            #endregion


            #endregion
        }
    }
}
