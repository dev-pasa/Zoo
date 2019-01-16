using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class Lion : Cats
    {
        /// <summary>
        /// define the print of the animal 
        /// </summary>
        public string Print { get; set; } = "Leopard Print";

        /// <summary>
        /// override the age of the animal 
        /// </summary>
        public override int Age { get; set; } = 14;

        /// <summary>
        /// give the animal its name 
        /// </summary>
        public override string Name { get; set; } = "Lion King";

        /// <summary>
        /// state the length of the claw
        /// </summary>
        public override int ClawLength { get; set; } = 6;

        /// <summary>
        /// define the type of food it eats
        /// </summary>
        /// <returns></returns>
        public override string Food()
        {
            return "Buffallo and wilder beasts";
        }

        /// <summary>
        /// define the sound the animal makes
        /// </summary>
        /// <returns></returns>
        public override string Sound()
        {
            return "Big Roar!!";
        }
        
        /// <summary>
        /// define whether the animal hunts in packs
        /// </summary>
        /// <returns></returns>
        public override string Hunts()
        {
            return "Hunt in a pack";
        }
       
        /// <summary>
        /// define whether the animal can climb trees
        /// </summary>
        /// <returns></returns>
        public override string ClimbsTree()
        {
            return "I king don't climb trees";
        }

        /// <summary>
        /// define the average number of cubs it gives birth to
        /// </summary>
        /// <returns></returns>
        public override string GiveBirth()
        {
            return "Three cubs are born";
        }
    }
}
