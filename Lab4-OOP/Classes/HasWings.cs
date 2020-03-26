using System;
namespace Lab4_OOP.Classes
{
    public abstract class HasWings : Land
    {
        public bool HaveWings { get; set; } = true;

        public void ImFlying()
        {
            Console.WriteLine("I fly so high");
        }
    }
}
