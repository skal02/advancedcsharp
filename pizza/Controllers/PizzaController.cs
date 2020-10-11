using System;
using Microsoft.AspNetCore.Mvc;
using pizza.Custom;
using pizza.Service;

namespace pizza.Controllers
{
    [ApiController]
    [ExceptionFilter]
    public class PizzaController : ControllerBase
    {
        private readonly PizzaService _pizzaService = new PizzaService();
        
        [HttpGet]
        [Route("[controller]")]
        public ActionResult Get()
        {
            return Ok(_pizzaService.GetPizzas());
        }
        
        [HttpGet]
        [Route("[controller]/{id:int:min(1)}")]
        public ActionResult<PizzaDto> Get(int id)
        {
            var pizza = _pizzaService.GetPizzas(id);

            if (pizza is null)
            {
                return NotFound();
            }
            
            return Ok(_pizzaService.GetPizzas(id));
        }
        
        [HttpGet]
        [Route("[controller]/{name}")]
        public ActionResult<PizzaDto> Get(string name)
        {
            var pizza = _pizzaService.GetPizzas(name);

            if (pizza is null)
            {
                return NotFound();
            }

            return Ok(_pizzaService.GetPizzas(name));
        }
        
        [HttpGet]
        [Route("error")]
        public ActionResult Throw()
        {
            throw new InvalidOperationException("This is an unhandled exception");
        }
    }
}