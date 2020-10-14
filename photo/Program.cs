using System;

namespace Delegates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            
            processor.Process("photo.jpg");
        }
    }
}