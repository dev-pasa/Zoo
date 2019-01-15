using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Crocodile : Reptile
    {
        public abstract bool EatHuman {get; set; }
        public override int Age { get; set; } = 15;
        public override string Name { get; set; } = "The Crocodillion";

        public override string Length { get; set; } = "8 feet";

        public override bool LayEggs { get; set; } = true;

        public override string Food()
        {
            return "Big animals and fish";
        }

        public override string Sound()
        {
            return "Roars, Growls andGrunts" ;
        }

    }
}
