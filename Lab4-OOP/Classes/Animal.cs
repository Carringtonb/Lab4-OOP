using System;


namespace Lab4_OOP.Classes
{
    /// <summary>
    /// Main class is hierarchy of zoo
    /// </summary>
   public abstract class Animal
    {
          public abstract int NumOfLegs { get; set; }
         public abstract bool HasTeeth { get; set; }
        public abstract string Diet { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// To define whether or not the current animal can be domesticated.
        /// </summary>
        public virtual string IsAPet()
        {
            string ans = "Am I your pet?";
            return ans;
        }
    }

}
