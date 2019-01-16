using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Crocodile : Reptile
    {
        /// <summary>
        /// abstract property if the animal eats human
        /// </summary>
        public abstract bool EatHuman {get; set; }

        /// <summary>
        /// override the age of the animal 
        /// </summary>
        public override int Age { get; set; } = 15;

        /// <summary>
        /// Give the animal its name
        /// </summary>
        public override string Name { get; set; } = "The Crocodillion";

        /// <summary>
        /// Assign the animal its length
        /// </summary>
        public override string Length { get; set; } = "8 feet";

        /// <summary>
        /// State whether the animal lays eggs
        /// </summary>
        public override bool LayEggs { get; set; } = true;

        /// <summary>
        /// Define the type of animal it eats
        /// </summary>
        /// <returns></returns>
        public override string Food()
        {
            return "Big animals and fish";
        }

        /// <summary>
        /// define the sound it makes. 
        /// </summary>
        /// <returns></returns>
        public override string Sound()
        {
            return "Roars, Growls andGrunts" ;
        }

    }
}
