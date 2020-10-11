using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace pizza.Service
{
    public static class PriceService
    {
        public static (double price, string currency) Get(double price)
        {
            var currency = "€";
            
            try
            {
                return (price.ConvertToEur(), currency);
            }
            catch (FormatException e)
            {
                Console.WriteLine("PriceService.FormatException: " + e);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine("PriceService.InvalidCastException: " + e);
            }
            catch (Exception e)
            {
                Console.WriteLine("PriceService.Exception: " + e.Message);
                throw new Exception("Server error");
            }
            finally
            {
                price = 9999;
            }

            return (price, currency);
        }
        
        private static double ConvertToEur(this double usd)
        {
            return Math.Round(usd * 0.85, 2);
        }
    }
}