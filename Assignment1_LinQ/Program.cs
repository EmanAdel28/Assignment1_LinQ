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
            var prouducts = from P in ProductList
                            where P.UnitsInStock == 0
                            select P;

            foreach (var product in prouducts)
            {
                Console.WriteLine(product);
            }

            #endregion
            #endregion
        }
    }
}
