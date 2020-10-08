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
        public ActionResult Get(int id)
        {
            if (id != 1)
            {
                return NotFound();
            }
            
            return Ok(_pizzaService.GetPizzas(1).ToString());
        }
    }
}