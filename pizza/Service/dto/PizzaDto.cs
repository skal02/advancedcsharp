using System;
using Microsoft.VisualBasic;

namespace pizza.Service
{
    public class PizzaDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        
        public PizzaDto(int id, string name, string description, dynamic price)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = string.Format("{0} {1}", price?.Item1, price?.Item2);
        }
    }
}