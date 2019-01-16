using System;
using System.Collections.Generic;
using System.Text;
using Zoo;

namespace Zoo.Classes
{
    public class Python : Reptile
    {
        /// <summary>
        /// override the age of the animal 
        /// </summary>
        public override int Age { get; set; } = 20;

        /// <summary>
        /// define the name of the reptile
        /// </summary>
        public override string Name { get; set; } = "The deadly python";

        /// <summary>
        /// state the length of the animal 
        /// </summary>
        public override string Length { get; set; } = "15 feet";

        /// <summary>
        /// bool property to state whether the animal lays eggs
        /// </summary>
        public override bool LayEggs { get; set; } = true;

        /// <summary>
        /// What type of food does the animal eat
        /// </summary>
        /// <returns></returns>
        public override string Food()
        {
            return "Love 2 legged animals";
        }

        /// <summary>
        /// define the sound the animal makes
        /// </summary>
        /// <returns></returns>
        public override string Sound()
        {
            return "Hisss!!";
        }

    }
}
