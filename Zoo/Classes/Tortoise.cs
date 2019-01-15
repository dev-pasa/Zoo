using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes 
{
    class Tortoise : Reptile
    {
        public override int Age { get; set; } = 20;
        public override string Name { get; set; } = "The Tortoise";

        public override string Length { get; set; } = "2 feet";

        public override bool LayEggs { get; set; } = true;

        public override string Food()
        {
            return "Fruits and everything good";
        }

        public override string Sound()
        {
            return "Tortoise sound";
        }
    }
}
