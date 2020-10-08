using System;

namespace pizza.Service
{
    public static class PriceService
    {
        public static double Get(double usd)
        {
            return ConvertToEur(usd);
        }
        
        private static double ConvertToEur(this double usd)
        {
            Console.WriteLine(usd * 0.85);
            return usd * 0.85;
        }
    }
}