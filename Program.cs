using System;

namespace CanteenOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FOOD ITEM\n");

            FoodItem siopao = new FoodItem("Siopao", 25.00m, 50);
            FoodItem sandwich = new FoodItem("Ham Sandwich", 45.50m, 0);

            Console.WriteLine("Initial State");
            Console.WriteLine(siopao.GetDetails());
            Console.WriteLine(sandwich.GetDetails());

            Console.WriteLine("\nTest 1: Valid Stock Update");
            Console.WriteLine($"Siopao: sell 10 → Expected: True, Actual: {siopao.UpdateStock(-10)}");
            Console.WriteLine(siopao.GetDetails());

            Console.WriteLine("\nTest 2: Rule Violation — Negative Stock");
            Console.WriteLine($"Sandwich: remove 5 → Expected: False, Actual: {sandwich.UpdateStock(-5)}");
            Console.WriteLine(sandwich.GetDetails());

            Console.WriteLine("\nTest 3: Restock Sandwich");
            Console.WriteLine($"Sandwich: add 20 → Expected: True, Actual: {sandwich.UpdateStock(20)}");
            Console.WriteLine(sandwich.GetDetails());

            Console.WriteLine("\nEND OF TESTS");
        }
    }
}
