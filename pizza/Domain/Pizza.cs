namespace pizza.Domain
{
    public class Pizza
    {
        public string Name { get; set; }
        
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Pizza(string name, string description, decimal price)
        {
            Name = name;
            Description = description;
            Price = price;
        }
    }
}