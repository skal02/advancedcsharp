using System;
using System.Collections.Generic;

namespace pizza.Domain
{
    public class PizzaRepository
    {
        public static List<Pizza> GetPizzas()
        {
            List<Pizza> pizzas = new List<Pizza>();

            pizzas.Add(new Pizza(
                "Hawaian", 
                "Sauce tomate, mozzarella, oignons, merguez, poivrons mélangés", 
                9));
            
            pizzas.Add(new Pizza(
                "4 fromages", 
                "Sauce tomate, mozzarella, oignons, merguez, poivrons mélangés", 
                9));
            
            pizzas.Add(new Pizza(
                "Orientale", 
                "Sauce tomate, mozzarella, oignons, merguez, poivrons mélangés", 
                9));
            
            pizzas.Add(new Pizza(
                "VEGAN PEPPINA PIZZAS", 
                "Sauce tomate, râpé vegan, champignons, oignons, poivrons mélangés, olives noires, tomates fraîches, origan", 
                9));

            return pizzas;
        }
    }
}