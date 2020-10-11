namespace pizza.Service
{
    public class BasketDto
    {
        public string PizzaName { get; set; }
        public string TotalPrice { get; set; }
        
        public BasketDto(int id, string pizzaName, string totalPrice)
        {
            PizzaName = pizzaName;
            TotalPrice = totalPrice;
        }
    }
}