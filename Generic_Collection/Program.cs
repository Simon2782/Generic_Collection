namespace Generic_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Skapar ett nytt restaurangobjek
            var restaurant = new Restaurant();

            //Lägger till rätter på menyn
            restaurant.AddToMenu(new MenuItem(1, "Carbonara", 80m));
            restaurant.AddToMenu(new MenuItem(2, "Pizza", 90m));
            restaurant.AddToMenu(new MenuItem(3, "Fried rice", 60m));
            restaurant.AddToMenu(new MenuItem(4, "Hamburger", 70m));

            Console.WriteLine("---------------------");


            //Skriver ut menyn
            restaurant.ShowMenu();

           
            //Lägger till ordrar
            var order1 = new Order(new List<MenuItem> { new MenuItem(1, "Carbonara", 80m), new MenuItem(2, "Pizza", 90m) }, 1);
            var order2 = new Order(new List<MenuItem> { new MenuItem(3, "Fried rice", 60m), new MenuItem(4, "Hamburger", 70m) }, 2);
            var order3 = new Order(new List<MenuItem> { new MenuItem(2, "Pizza", 90m), new MenuItem(4, "Hamburger", 70m) }, 3);

            Console.WriteLine("---------------------");


            restaurant.CreateOrder(order1);
            restaurant.CreateOrder(order2);
            restaurant.CreateOrder(order3);

            Console.WriteLine("---------------------");
            
            //Visar ordrarna
            restaurant.ShowOrders();

            Console.WriteLine("---------------------");

            //Visar antalet ordrar i kön
            restaurant.ShowOrderCount();

            Console.WriteLine("---------------------");

            //Visar den order som är först i kön
            restaurant.ShowNextOrder();

            Console.WriteLine("---------------------");

            //Hanterar en den order som är först i kön
            restaurant.HandleOrder();

            Console.WriteLine("---------------------");

            //Visar antalet ordrar i kön
            restaurant.ShowOrderCount();

            Console.WriteLine("---------------------");

            //Skapar en ny order
            var order4 = new Order(new List<MenuItem> { new MenuItem(2, "Pizza", 90m), new MenuItem(4, "Hamburger", 70m) }, 4);
            restaurant.CreateOrder(order4);

            Console.WriteLine("---------------------");


            restaurant.ShowOrderCount();

            Console.WriteLine("---------------------");

            restaurant.HandleOrder();
            restaurant.HandleOrder();

            Console.WriteLine("---------------------");

            restaurant.ShowOrderCount();

            Console.WriteLine("---------------------");

            restaurant.ShowNextOrder();

            Console.WriteLine("---------------------");

            restaurant.HandleOrder();

            Console.WriteLine("---------------------");

            restaurant.ShowOrderCount();



        }
    }
}
