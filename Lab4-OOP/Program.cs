using System;
using Lab4_OOP.Classes;
using Lab4_OOP.Interfaces;

namespace Lab4_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ISpeak[] Speaker = new ISpeak[4];

            Manticore ElPapi = new Manticore { Diet = "Blood and Bones", Lift = (1000 * 32.17), Intro = "I am ElPapi" };
            Mermaid KanyeBass = new Mermaid { Diet = "FishSticks", IsIntelligent = true, Intro = "I love FishSticks" };
            Eagle Freedom = new Eagle { HasFins = false, NumWings = 50, Lift = 1817 };
            Rhino Rocksteady = new Rhino { NumOfLegs = 4, Diet = "Carnivore", Intro = "I'm gonna crush those pesky ninja turtles" };
            Dragon Oenomaus = new Dragon { IsIntelligent = true, Intro = "Im a DAWG BOWWWWWWW", Diet = "All meat baby", HasTeeth = true };

            Speaker[0] = ElPapi;
            Speaker[1] = KanyeBass;
            Speaker[2] = Rocksteady;
            Speaker[3] = Oenomaus;

            for (int i = 0; i < Speaker.Length; i++)
            {
                var speakers = Speaker[i];

                if (speakers is HasWings)
                {
                    var speakingWings = (HasWings)speakers;
                    speakingWings.ImFlying();
                } else if(speakers is NoWings)
                {
                    var grounded = (NoWings)speakers;
                    grounded.GroundBB();
                }
            }

        }
    }
}
