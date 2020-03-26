using System;
using Xunit;
using Lab4_OOP;
using Lab4_OOP.Classes;

namespace UnitTest1
{
    public class Test
    {
        [Fact]
        public void TestThatDragonInheritsBehaviors()
        {
            Dragon dragon = new Dragon() { Name = "Trogdor" };

            string input =$"{dragon.Name} {dragon.IsAPet()}";
            string expected = $"{dragon.Name} Am I your pet?";

            Assert.Equal(expected, input);
        }

        [Fact]
        public void TestThatManticoreInheritsBehaviors()
        {
            Manticore manty = new Manticore() { Name = "Manty" };

            string input =$"{manty.Name} {manty.IsAPet()}";
            string expected = $"{manty.Name} Am I your pet?";

            Assert.Equal(expected, input);
        }

        [Fact]
        public void TestThatMermaidInheritsBehaviors()
        {
            Mermaid sesi = new Mermaid() { Name = "Sesi" };

            string input =$"{sesi.Name} {sesi.IsAPet()}";
            string expected = $"{sesi.Name} Am I your pet?";

            Assert.Equal(expected, input);
        }

        [Fact]
        public void TestThatEagleInheritsBehaviors()
        {
            Eagle mordor = new Eagle() { Name = "Mordor" };

            string input =$"{mordor.Name} {mordor.IsAPet()}";
            string expected = $"{mordor.Name} Am I your pet?";

            Assert.Equal(expected, input);
        }

        [Fact]
        public void TestThatRhinoiInheritsBehaviors()
        {
            Rhino hornBoy = new Rhino() { Name = "HornBoy" };

            string input =$"{hornBoy.Name} {hornBoy.IsAPet()}";
            string expected = $"{hornBoy.Name} Am I your pet?";

            Assert.Equal(expected, input);
        }
    }
}
