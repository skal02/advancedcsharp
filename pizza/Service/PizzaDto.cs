namespace pizza.Service
{
    public class PizzaDto
    {
        public string Name { get; set; }

        public PizzaDto(string name)
        {
            Name = name;
        }
    }
}