using System;
using Lab4_OOP.Interfaces;

namespace Lab4_OOP.Classes
{
    public class Rhino : Land, ISpeak
    {
        public Rhino()
        {
        }

        public string Intro { get; set; } = "Bwakah!";
        public bool IsIntelligent { get; set; } = false;
        public override int NumOfLegs { get; set; } = 4;
        public override bool HasTeeth { get; set; } = true;
        public override string Diet { get; set; } = "Herbivore";
    }
}
