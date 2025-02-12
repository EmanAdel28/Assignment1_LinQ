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

            foreach (var customer in CustomerList)
            {
                Console.WriteLine($"{customer}  \n");
            }
            #endregion
        }
    }
}
