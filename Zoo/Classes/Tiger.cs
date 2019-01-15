using System;
using System.Collections.Generic;
using System.Text;
using Zoo.interfaces;

namespace Zoo.Classes
{
   public class Tiger:Cats, ICanSwim, IHuntWaterAndLand
    {
        public string Print { get; set; } = "Tigaa Print";

        public override int Age { get; set; } = 15;
       
        public override string Name { get; set; } = "Tigaa";

        public override int ClawLength { get; set; } = 5;


        public override string Food()
        {
            return "Buffallo and deers";
        }

        public override string Sound()
        {
            return "Roar!!!";
        }
        public override string ClimbsTree()
        {
            return "I am the king of jungle, I don't climb trees";
        }

        public override string Hunts()
        {
            return "I hunt big animals by myself.";
        }

        public override string GiveBirth()
        {
            return "Three cubs are born!!";
        }

        public string Swim()
        {
            return "I can swim and catch things in water.";
        }

        public string DryOff()
        {
            return "I don't need sun to dry off.";
        }

        public bool haveToEatInLand { get; set; } = false;

        public string HuntInWater()
        {
            return "I am ok at hungting in water";
        }
    }
}
