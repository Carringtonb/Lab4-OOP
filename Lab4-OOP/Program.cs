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

            Animal[] animals = new Animal[5];
            ISpeak[] Speaker = new ISpeak[4];

            Manticore ElPapi = new Manticore {Name = "ElPapi", Diet = "Blood and Bones", Lift = (1000 * 32.17), Intro = "I am ElPapi" };
            Mermaid KanyeBass = new Mermaid {Name = "KanyeBass", Diet = "FishSticks", IsIntelligent = false, Intro = "I love FishSticks" };
            Eagle Freedom = new Eagle {Name = "Freedom", HasFins = false, NumWings = 50, Lift = 1817, Diet = "Worms" };
            Rhino Rocksteady = new Rhino {Name = "Rocksteady", NumOfLegs = 4, Diet = "Meat and more meat", Intro = "I'm gonna crush those pesky ninja turtles" };
            Dragon Oenomaus = new Dragon {Name = "Oenomaus", IsIntelligent = true, Intro = "Im a DAWG BOWWWWWWW", Diet = "All meat baby", HasTeeth = true };

            Speaker[0] = ElPapi;
            Speaker[1] = KanyeBass;
            Speaker[2] = Rocksteady;
            Speaker[3] = Oenomaus;

            animals[0] = ElPapi;
            animals[1] = KanyeBass;
            animals[2] = Freedom;
            animals[3] = Rocksteady;
            animals[4] = Oenomaus;

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
            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine($"My name is {animals[i].Name} and I like to eat {animals[i].Diet}");
            }

        }
    }
}
