using System.Collections.Generic;
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

            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //double shortestWordLength = words.Average(word => word.Length);

            //Console.WriteLine(shortestWordLength);
            #endregion

            #region Q9
            //var categoryStock = ProductList
            //               .GroupBy(p => p.Category)
            //               .Select(g => new
            //               {
            //                   Category = g.Key,
            //                   TotalUnits = g.Sum(p => p.UnitsInStock)
            //               });

            //foreach (var item in categoryStock)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Total Units in Stock: {item.TotalUnits}");
            //}

            #endregion

            #region Q10
            //10. Get the cheapest price among each category's products

            var cheapestPrices = ProductList
                                 .GroupBy(p => p.Category)
                                 .Select(g => new
                                 {
                                     Category = g.Key,
                                     CheapestPrice = g.Min(p => p.UnitPrice)
                                 });

            foreach (var item in cheapestPrices)
            {
                Console.WriteLine($"Category: {item.Category}, Cheapest Price: {item.CheapestPrice:C}");
            }
            #endregion

            #region Q11
            //11. Get the products with the cheapest price in each category (Use Let)
            //var cheapestProducts = from p in ProductList
            //                       group p by p.Category into g
            //                       let minPrice = g.Min(p => p.UnitPrice)
            //                       from p in g
            //                       where p.UnitPrice == minPrice
            //                       select new { p.Category, p.ProductName, p.UnitPrice };

            //foreach (var item in cheapestProducts)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Product: {item.ProductName}, Price: {item.UnitPrice:C}");
            //}
            #endregion

            #region Q12
            //12. Get the most expensive price among each category's products.
            //        var expensivePrices = ProductList
            //.                             GroupBy(p => p.Category)
            //                              .Select(g => new
            //                                 {
            //                                   Category = g.Key,
            //                                   MostExpensivePrice = g.Max(p => p.UnitPrice)
            //                                 });

            //        foreach (var item in expensivePrices)
            //        {
            //            Console.WriteLine($"Category: {item.Category}, Most Expensive Price: {item.MostExpensivePrice:C}");
            //        }
            #endregion

            #region Q13
            //13. Get the products with the most expensive price in each category.
            //var Result = from p in ProductList
            //                            group p by p.Category into g
            //                            let maxPrice = g.Max(p => p.UnitPrice)
            //                            from p in g
            //                            where p.UnitPrice == maxPrice
            //                            select new { p.Category, p.Name, p.Price };

            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Product: {item.Name}, Price: {item.Price:C}");
            //}
            #endregion

            #region Q14
            //14. Get the average price of each category's products.
            //        var Result = ProductList
            //.GroupBy(p => p.Category)
            //.Select(g => new
            //{
            //    Category = g.Key,
            //    AveragePrice = g.Average(p => p.UnitPrice)
            //});

            //        foreach (var item in Result)
            //        {
            //            Console.WriteLine($"Category: {item.Category}, Average Price: {item.AveragePrice:C}");
            //        }
            #endregion
            #endregion

            #region Ordering Operators
            #region Q1
            //1. Sort a list of products by name
            //var Products = ProductList
            //                     .OrderBy(p => p.ProductName);

            //foreach (var product in Products)
            //{
            //    Console.WriteLine(product);
            //}


            #endregion

            #region Q2
            //2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var sortedWords = Arr.OrderBy(word => word, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in sortedWords)
            //{
            //    Console.WriteLine(word);
            //}



            #endregion

            #region Q3
            // 3. Sort a list of products by units in stock from highest to lowest.
            //var sortedByStock = ProductList.OrderByDescending(p => p.UnitsInStock);

            //foreach (var product in sortedByStock)
            //{
            //    Console.WriteLine(product);
            //}



            #endregion

            #region Q4
            //4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            //string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var sortedDigits = digits
            //    .OrderBy(d => d.Length)  
            //    .ThenBy(d => d);         

            //foreach (var digit in sortedDigits)
            //{
            //    Console.WriteLine(digit);
            //}
            #endregion

            #region Q5
            //5. Sort first by-word length and then by a case-insensitive sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var sortedWords = Arr
            //    .OrderBy(word => word.Length) 
            //    .ThenBy(word => word, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in sortedWords)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion

            #region Q6
            // Sort products first by category, then by unit price (highest to lowest)

            //var sortedProducts = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice); 

            //foreach (var product in sortedProducts)
            //{
            //    Console.WriteLine(product);
            //}

            #endregion

            #region Q7
            //7.Sort first by-word length and then by a case -insensitive descending sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var sortedWordsDescending = Arr
            //    .OrderBy(word => word.Length) // First by length
            //    .ThenByDescending(word => word, StringComparer.OrdinalIgnoreCase); // Then case-insensitively (descending)

            //foreach (var word in sortedWordsDescending)
            //{
            //    Console.WriteLine(word);
            //}



            #endregion

            #region Q7
            //8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var filteredAndReversed = Arr
                .Where(word => word.Length > 1 && word[1] == 'i') 
                .Reverse(); 

            foreach (var word in filteredAndReversed)
            {
                Console.WriteLine(word);
            }




            #endregion
            #endregion



        }
    }
}
