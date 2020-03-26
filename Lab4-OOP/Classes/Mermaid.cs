using System;
using Lab4_OOP.Interfaces;

namespace Lab4_OOP.Classes
{
   public class Mermaid : NoWings , ISpeak
    {
        public override int NumOfLegs { get; set; } = 0;
        public override bool HasTeeth { get; set; } = true;
        public override string Diet { get; set; } = "Fish and Kelp";
        public string Intro { get; set; } = "I am a mermaid, maybe a merman";
        public bool IsIntelligent { get; set; } = true;
    }

}
