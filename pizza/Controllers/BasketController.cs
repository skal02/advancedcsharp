using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using pizza.Custom;
using pizza.Service;

namespace pizza.Controllers
{
    [ApiController]
    [ExceptionFilter]
    [Route("[controller]")]
    public class BasketController : ControllerBase
    {
        private static CacheManager _instance = null;

        public static CacheManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CacheManager();
                }
                return _instance;
            }
        }
        
        private static readonly string _cacheKey = "_basket";
        private readonly PizzaService _pizzaService = new PizzaService();

        [HttpGet]
        public ActionResult<BasketDto> Get()
        {
            BasketDto basket;
            
            if (Instance.Cache.TryGetValue(_cacheKey, out basket))
            {
                return Ok(basket);
            }

            return NotFound();
        }
        
        [HttpPost]
        public ActionResult<BasketDto> Post(string name)
        {
            PizzaDto pizza = _pizzaService.GetPizzas(name);
            
            if (!pizza.Equals(null))
            {
                BasketDto basket = new BasketDto(1, pizza.Name, pizza.Price);
                
                Instance.Cache.Set(_cacheKey, basket);

                return Ok(basket);
            }
            
            return NotFound();
        }
    }
}