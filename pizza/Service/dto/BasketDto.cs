namespace pizza.Service
{
    public class BasketDto
    {
        public string PizzaName { get; set; }
        public string Price { get; set; }
        
        public BasketDto(int id, string pizzaName, string price)
        {
            PizzaName = pizzaName;
            Price = price;
        }
    }
}