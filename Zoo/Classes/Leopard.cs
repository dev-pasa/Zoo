using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class Leopard : Cats
    {
        /// <summary>
        /// Define leopard print
        /// </summary>
        public string Print { get; set; } = "Leopard Print";

        /// <summary>
        /// Define the name of the leopard
        /// </summary>
        public override string Name { get; set; } = "The fast Leopard";

        /// <summary>
        /// Assign the age of the Leopard
        /// </summary>
        public override int Age { get; set; } = 9;

        /// <summary>
        /// override the claw length
        /// </summary>
        public override int ClawLength { get; set; } = 5;

        /// <summary>
        /// Define the food it eats
        /// </summary>
        /// <returns></returns>
        public override string Food()
        {
            return "Deers and hogs";
        }

        /// <summary>
        /// Override the sound the animal makes
        /// </summary>
        /// <returns></returns>
        public override string Sound()
        {
            return "Hiss and growl!!";
        }

        /// <summary>
        /// override how it hunts
        /// </summary>
        /// <returns></returns>
        public override string Hunts()
        {
            return "I hunt by myself";
        }

        /// <summary>
        /// method to describe if it can climb a tree or not. 
        /// </summary>
        /// <returns></returns>
        public override string ClimbsTree()
        {
            return "I can run and climb trees";
        }

        /// <summary>
        /// How many cubs in average it gives birth to
        /// </summary>
        /// <returns></returns>
        public override string GiveBirth()
        {
            return "Four cubs are born";
        }
    }
}
