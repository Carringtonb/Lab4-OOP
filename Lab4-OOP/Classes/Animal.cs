using System;


namespace Lab4_OOP.Classes
{
   public abstract class Animal
    {
          public abstract int NumOfLegs { get; set; }
         public abstract bool HasTeeth { get; set; }
        public abstract string Diet { get; set; }

        public virtual void IsAPet()
        {
            Console.WriteLine("Am I your pet?");
        }
    }

}
