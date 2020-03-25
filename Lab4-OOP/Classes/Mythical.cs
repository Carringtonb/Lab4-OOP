using System;
namespace Lab4_OOP.Classes
{
    public abstract class Mythical : Animal
    {
        public Mythical()
        {
        }
        public void ImMythical()
        {
            Console.WriteLine("I only exist in your dreams");
        }
    }
}
