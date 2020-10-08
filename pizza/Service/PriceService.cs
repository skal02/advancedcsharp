using System;

namespace pizza.Service
{
    public static class PriceService
    {
        public static double Get(double price)
        {
            return price.ConvertToEur();
        }
        
        private static double ConvertToEur(this double usd)
        {
            return usd * 10;
        }
    }
}