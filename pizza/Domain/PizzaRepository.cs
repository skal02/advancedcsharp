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
                1,
                "hawaian", 
                "Sauce tomate, mozzarella, poulet, oignons, ananas, poivrons mélangés", 
                0));
            
            pizzas.Add(new Pizza(
                2,
                "4 fromages", 
                "Sauce tomate, mozzarella, oignons, chèvre, poivrons mélangés", 
                15));
            
            pizzas.Add(new Pizza(
                3,
                "orientale", 
                "Sauce tomate, mozzarella, oignons, merguez, poivrons mélangés", 
                12));
            
            pizzas.Add(new Pizza(
                4,
                "vegan", 
                "Sauce tomate, râpé vegan, champignons, oignons, poivrons mélangés, olives noires, tomates fraîches, origan", 
                25));

            return pizzas;
        }
    }
}