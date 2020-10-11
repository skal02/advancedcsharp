using Microsoft.VisualStudio.TestPlatform.Common.Utilities;
using NUnit.Framework;
using pizza.Service;

namespace TestProject.Pizza
{
    public class Tests
    {
        private readonly PizzaService _pizzaService = new PizzaService();
        
        [SetUp]
        public void Setup()
        {
        }
        
        [Test]
        public void IsPizzaGetOne_ReturnTrue()
        {
            var result = _pizzaService.GetPizzas(1).Name;
            Assert.IsTrue(result == "hawaian");
        }
        
        [Test]
        public void IsPizzaGetTen_ReturnFalse()
        {
            var result = _pizzaService.GetPizzas(10);
            Assert.IsTrue(result == null);
        }
    }
}


