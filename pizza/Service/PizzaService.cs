using System;
using System.Collections.Generic;
using System.Linq;
using pizza.Domain;

namespace pizza.Service
{
    public class PizzaService
    {
        public List<PizzaDto> GetPizzas()
        {
            var pizzas = convertPizza(PizzaRepository.GetPizzas());
            return pizzas;
        }
        
        public PizzaDto GetPizzas(int id)
        {
            var pizzas = convertPizza(PizzaRepository.GetPizzas());
            return pizzas.First();
        }
        private List<PizzaDto> convertPizza(List<Pizza> pizzas)
        {
            var outputPizzas = new List<PizzaDto>();
            foreach (var pizza in pizzas)
            {
                var p = new PizzaDto(pizza.Name);
                outputPizzas.Add(p);
            }

            return outputPizzas;
        }
    }
}
