namespace Generic_Collection
{
    internal class Restaurant
    {
        private List<MenuItem> _menu;
        private Queue<Order> _orders;

        public Restaurant()
        {
            _menu = new List<MenuItem>();
            _orders = new Queue<Order>();
        }

        public void AddToMenu(MenuItem menuItem)
        {
            _menu.Add(menuItem);
            Console.WriteLine($"Added to menu: {menuItem}");
        }

        public void ShowMenu()
        {
            Console.WriteLine("Menu");
            foreach (var item in _menu)
            {
                Console.WriteLine(item);
            }
        }

        public void CreateOrder(Order order)
        {
            _orders.Enqueue(order);
            Console.WriteLine("Order added to queue.");
        }

        public void HandleOrder()
        {
            if (_orders.Count > 0)
            {
                var order = _orders.Dequeue();
                Console.WriteLine("Handling order:");
                order.PrintOrder();
            }
            else
            {
                Console.WriteLine("No orders to handle.");
            }
        }

        public void ShowOrders()
        {
            Console.WriteLine("Current orders in queue:");
            foreach (var order in _orders)
            {
                order.PrintOrder();
            }
        }

        public void ShowNextOrder()
        {
            if (_orders.Count > 0)
            {
                Console.WriteLine("Next order in queue:");
                _orders.Peek().PrintOrder();
            }
            else
            {
                Console.WriteLine("No orders in queue");
            }
        }

        public void ShowOrderCount()
        {
            if (_orders.Count > 0)
            {
                Console.WriteLine($"Total orders in queue: {_orders.Count}");
            }
            else
            {
                Console.WriteLine("There is no orders in the queue.");
            }
        }
    }
}
