using System;
using System.Collections.Generic;
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
        private static CacheManager _instance;

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
            List<BasketDto> baskets;
            
            if (Instance.Cache.TryGetValue(_cacheKey, out baskets))
            {
                return Ok(baskets);
            }

            return NotFound();
        }
        
        [HttpDelete]
        public ActionResult<BasketDto> Clear()
        {
            Instance.Cache.Remove(_cacheKey);

            return Ok();
        }
        
        [HttpPost]
        public ActionResult<BasketDto> Post(string name)
        {
            PizzaDto pizza = _pizzaService.GetPizzas(name);
            
            if (!pizza.Equals(null))
            {
                List<BasketDto> baskets;
                Instance.Cache.TryGetValue(_cacheKey, out baskets);
                
                if (baskets is null)
                {
                    baskets = new List<BasketDto>();
                }
                
                baskets.Add(new BasketDto(1, pizza.Name, pizza.Price));
                Instance.Cache.Set(_cacheKey, baskets);

                return Ok(baskets);
            }
            
            return NotFound();
        }
    }
}