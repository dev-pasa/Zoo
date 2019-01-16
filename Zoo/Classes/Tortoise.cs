using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes 
{
    public class Tortoise : Reptile
    {
        /// <summary>
        /// override the age of the turtle
        /// </summary>
        public override int Age { get; set; } = 20;

        /// <summary>
        /// give the tortoise its name
        /// </summary>
        public override string Name { get; set; } = "The Tortoise";

        /// <summary>
        /// set the length of the tortoise
        /// </summary>
        public override string Length { get; set; } = "2 feet";

        /// <summary>
        /// give a boolean property to state whether the animal lays eggs
        /// </summary>
        public override bool LayEggs { get; set; } = true;

        /// <summary>
        /// define the type of food the animal eats
        /// </summary>
        /// <returns></returns>
        public override string Food()
        {
            return "Fruits and everything good";
        }

        /// <summary>
        /// define the type of sound the tortoise makes
        /// </summary>
        /// <returns></returns>
        public override string Sound()
        {
            return "Tortoise sound";
        }
    }
}
