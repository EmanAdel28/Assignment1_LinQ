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
            //1.Find all products that are out of stock.
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
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var shortNameDigits = Arr
            //.Select((name, index) => new { Name = name, Value = index })
            //.Where(digit => digit.Name.Length < digit.Value)
            //.Select(digit => digit.Name);

            //foreach (var digit in shortNameDigits)
            //{
            //    Console.WriteLine(digit);
            //}
            #endregion


            #endregion

            #region Element Operators
            #region Q1
            // Get first Product out of Stock 
            //var prouducts = ProductList.FirstOrDefault(P => P.UnitsInStock == 0);
            //Console.WriteLine(prouducts);
            #endregion

            #region Q2
            //2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //var prouducts = ProductList.FirstOrDefault(P => P.UnitPrice>1000);
            //Console.WriteLine(prouducts);
            #endregion

            #region Q3
            //3. Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = Arr.Where(n => n > 5).Skip(1).FirstOrDefault();

            //Console.WriteLine(Result);

            #endregion

            #endregion

            #region Aggregate Operators
            #region Q1
            //1.Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = Arr.Count(N => N % 2 == 1);
            //Console.WriteLine(Result);

            #endregion

            #region Q2
            //2. Return a list of customers and how many orders each has.

            // var customerOrderCounts = CustomerList
            //.Select(c => new
            //{
            //    CustomerName = c.CustomerName,
            //    OrderCount = c.Orders.Count()
            //});

            // foreach (var customer in customerOrderCounts)
            // {
            //     Console.WriteLine($"Customer: {customer.CustomerName}, Orders: {customer.OrderCount}");
            // }
            #endregion

            #region Q3
            //3. Return a list of categories and how many products each has
            //var categoryProductCounts = ProductList
            //                           .GroupBy(p => p.Category)
            //                           .Select(g => new
            //                            {
            //                             CategoryName = g.Key,
            //                             ProductCount = g.Count()
            //                            });

            //foreach (var category in categoryProductCounts)
            //{
            //    Console.WriteLine($"Category: {category.CategoryName}, Products: {category.ProductCount}");
            //}
            #endregion

            #region Q4
            //4. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Sum = Arr.Sum();
            //Console.WriteLine(Sum);
            #endregion

            #region Q5
            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //int totalCharacters = words.Sum(word => word.Length);

            //Console.WriteLine($"Total number of characters in dictionary: {totalCharacters}");

            #endregion

            #region Q6
            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //int shortestWordLength = words.Min(word => word.Length);

            //Console.WriteLine( shortestWordLength);
            #endregion

            #region Q7
            //7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //int shortestWordLength = words.Max(word => word.Length);

            //Console.WriteLine(shortestWordLength);
            #endregion

            #region Q8
            //8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            string[] words = File.ReadAllLines("dictionary_english.txt");

            double shortestWordLength = words.Average(word => word.Length);

            Console.WriteLine(shortestWordLength);
            #endregion
            #endregion

        }
    }
}
