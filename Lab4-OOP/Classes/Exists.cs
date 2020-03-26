using System;
namespace Lab4_OOP.Classes
{
    public abstract class Exists : Animal
    {
        public override abstract int NumOfLegs { get; set; }
        public override abstract bool HasTeeth { get; set; }
        public override abstract string Diet { get; set; }
       
    }
}
