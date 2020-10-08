using Microsoft.AspNetCore.Mvc;
using pizza.Service;

namespace pizza.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzaController : ControllerBase
    {
        private readonly PizzaService _pizzaService = new PizzaService();
        
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_pizzaService.GetPizzas());
        }
        
        [HttpGet]
        [Route("{id:int:min(1)}")]
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
        [Route("{name}")]
        public ActionResult<PizzaDto> Get(string name)
        {
            var pizza = _pizzaService.GetPizzas(name);
            
            if (pizza is null)
            {
                return NotFound();
            }
            
            return Ok(_pizzaService.GetPizzas(name));
        }
    }
}