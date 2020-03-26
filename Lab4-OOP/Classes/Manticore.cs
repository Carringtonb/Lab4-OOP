using System;
using Lab4_OOP.Interfaces;

namespace Lab4_OOP.Classes
{
    public class Manticore : HasWings, ISpeak, IFly
    {
        public Manticore()
        {
        }
        public override int NumOfLegs { get; set; } = 4;
        public override bool HasTeeth { get; set; } = true;
        public override string Diet { get; set; } = "Blood and Bones";
        public string Intro { get; set; } = "I am a beautiful Manticore";
        public bool IsIntelligent { get; set; } = true;
        public int NumWings { get; set; } = 2;
        public double Lift { get; set; } = (1000 * 32.17);
    }
   
}
