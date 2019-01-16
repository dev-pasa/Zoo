using System;
using System.Collections.Generic;
using System.Text;
using Zoo.interfaces;

namespace Zoo.Classes
{
    public class Gharial : Crocodile, IHuntWaterAndLand, ICanSwim
    { 
        /// <summary>
        /// Set propert to define that the animal eats humans
        /// </summary>
        public override bool EatHuman { get; set; } = true;

        /// <summary>
        /// Override the age of the animal
        /// </summary>
        public override int Age { get; set; } = 10;

        /// <summary>
        /// Override the name of the animal
        /// </summary>
        public override string Name { get; set; } = "The thin mouth Gharial";

        /// <summary>
        /// give the lenght of the animal
        /// </summary>
        public override string Length { get; set; } = "8 feet";

        /// <summary>
        /// Override whether it lays eggs
        /// </summary>
        public override bool LayEggs { get; set; } = true;

        /// <summary>
        /// Define the type of food it eats
        /// </summary>
        /// <returns></returns>
        public override string Food()
        {
            return "Small animals and fish";
        }

        /// <summary>
        /// define the sound it makes
        /// </summary>
        /// <returns></returns>
        public override string Sound()
        {
            return "Reptile sound";
        }

        /// <summary>
        /// Interface property to explain if the animal swims
        /// </summary>
        /// <returns></returns>
        public string Swim()
        {
            return "Water is like my second home";
        }

        /// <summary>
        /// CAn the animal dryoff by itself
        /// </summary>
        /// <returns></returns>
        public string DryOff()
        {
            return "I need sun to dry off";
        }

        /// <summary>
        /// bool property to define if the animal has to eat in land
        /// </summary>
        public bool haveToEatInLand { get; set; } = false;


        /// <summary>
        /// Can the animal hunt in water.
        /// </summary>
        /// <returns></returns>
        public  string HuntInWater()
        {
            return " I am great at hungting in water";
        }

    }
}
