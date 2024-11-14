namespace Generic_Collection
{
    internal class Order
    {
        static int orderIdCounter = 1;
        private int _orderId;
        private List<MenuItem> _orderItems;
        private int _tableNumber;

        public Order(List<MenuItem> orderItems, int tableNumber)
        {
            // Automatiskt skapande av id
            _orderId = orderIdCounter;
            orderIdCounter++;
            _orderItems = orderItems;
            _tableNumber = tableNumber;
        }

        public void PrintOrder()
        {
            Console.WriteLine($"Order: {_orderId} | Table: {_tableNumber}");
            foreach (var item in _orderItems)
            {
                Console.WriteLine(item);
            }
        }
    }
}
