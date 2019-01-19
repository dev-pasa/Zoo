using System;
using System.Collections.Generic;
using System.Text;
using Zoo.interfaces;

namespace Zoo.Classes
{
   public class Tiger:Cats, ICanSwim, IHuntWaterAndLand
    {
        /// <summary>
        /// define the sking print of the animal 
        /// </summary>
        public string Print { get; set; } = "Tigaa Print";

        /// <summary>
        /// define the average age of the animal 
        /// </summary>
        public override int Age { get; set; } = 15;
       
        /// <summary>
        /// give the tiger its name
        /// </summary>
        public override string Name { get; set; } = "Tigaa";

        /// <summary>
        /// state the average length of the tiger's claw
        /// </summary>
        public override int ClawLength { get; set; } = 5;


        public override string Food()
        {
            return "Buffallo and deers";
        }

        /// <summary>
        /// define the type of sound the animal makes
        /// </summary>
        /// <returns></returns>
        public override string Sound()
        {
            return "Roar!!!";
        }

        /// <summary>
        /// define whether the animal can climb the tree
        /// </summary>
        /// <returns></returns>
        public override string ClimbsTree()
        {
            return "I am the king of jungle, I don't climb trees";
        }

        /// <summary>
        /// define whether the animal can hunt
        /// </summary>
        /// <returns></returns>
        public override string Hunts()
        {
            return "I hunt big animals by myself.";
        }

        /// <summary>
        /// how many cubs can the animal give birth to in average
        /// </summary>
        /// <returns></returns>
        public override string GiveBirth()
        {
            return "Three cubs are born!!";
        }

        /// <summary>
        /// define whether the animal can swim 
        /// </summary>
        /// <returns></returns>
        public string Swim()
        {
            return "I can swim and catch things in water.";
        }

        /// <summary>
        /// deifne whether it can dry off by itself. 
        /// </summary>
        /// <returns></returns>
        public string DryOff()
        {
            return "I don't need sun to dry off.";
        }
        
        /// <summary>
        /// define whether the animal has to eat in land
        /// </summary>
        public bool haveToEatInLand { get; set; } = false;

        /// <summary>
        /// state whether it can hunt in water
        /// </summary>
        /// <returns></returns>
        public string HuntInWater()
        {
            return "I am ok at hungting in water";
        }

        /// <summary>
        /// override virtual Sleep method
        /// </summary>
        /// <returns></returns>
        public override string Sleep()
        {
            return "sleep 8 hours";
        }
    }
}
