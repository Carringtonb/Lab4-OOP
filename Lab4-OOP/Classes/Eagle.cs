using System;
using Lab4_OOP.Interfaces;

namespace Lab4_OOP.Classes
{
    class Eagle : Water, IFly
    {
        public override int NumOfLegs { get; set; } = 2;
        public override bool HasTeeth { get; set; } = true;
        public override string Diet { get; set; } = "omnivore";
        public int NumWings { get; set; } = 18;
        public double Lift { get; set; } = (35 * 32.17);
        public override bool HasFins { get; set; } = false;
    }

}
