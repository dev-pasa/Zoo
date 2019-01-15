using System;
using System.Collections.Generic;
using System.Text;
using Zoo.interfaces;

namespace Zoo.Classes
{
    class Gharial : Crocodile, IHuntWaterAndLand, ICanSwim
    { 
        public override bool EatHuman { get; set; } = true;

        public override int Age { get; set; } = 10;
        public override string Name { get; set; } = "The Reptile";

        public override string Length { get; set; } = "8 feet";

        public override bool LayEggs { get; set; } = true;

        public override string Food()
        {
            return "Small animals and fish";
        }

        public override string Sound()
        {
            return "Reptile sound";
        }

        public string Swim()
        {
            return "Water is like my second home";
        }

       
        public string DryOff()
        {
            return "I need sun to dry off";
        }

        public bool haveToEatInLand { get; set; } = false;

        public  string HuntInWater()
        {
            return " I am great at hungting in water";
        }

    }
}
