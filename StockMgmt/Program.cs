using System;

namespace Stock
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock();//creating object
            Console.WriteLine("Welcome to Stock Account Management!");
            Console.WriteLine("\n");
            stock.add();//calling add() from stock.cs

        }
    }
}