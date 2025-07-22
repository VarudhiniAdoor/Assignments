namespace Assignment7
{
    public class Program
    {
        public static void Main()
        {
            List<Pizza> pizzaOrders = new List<Pizza>();

            pizzaOrders.Add(new Pizza("Small", 2, 1, 1));
            pizzaOrders.Add(new Pizza("Medium", 1, 2, 2));
            pizzaOrders.Add(new Pizza("Large", 3, 3, 3));

            foreach (Pizza pizza in pizzaOrders)
            {
                pizza.GetDescription();
                Console.WriteLine($"Total Cost: ${pizza.CalcCost()}\n");
              
            }
        }
    }
}

