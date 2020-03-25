using System;
using Lab4_OOP.Interfaces;

namespace Lab4_OOP.Classes
{
    class Dragon : HasWings, ISpeak, IFly
    {
        public int NumWings { get; set; }
        public double Lift { get; set; }
        public override int NumOfLegs { get; set; }
        public override bool HasTeeth { get; set; }
        public override string Diet { get; set; }
        public string Intro { get; set; }
        public bool IsIntelligent { get; set; }
    }
}
