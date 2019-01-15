using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class Python : Reptile
    {
        public override int Age { get; set; } = 20;
        public override string Name { get; set; } = "The Reptile";

        public override string Length { get; set; } = "15 feet";

        public override bool LayEggs { get; set; } = true;

        public override string Food()
        {
            return "Love 2 legged animals";
        }

        public override string Sound()
        {
            return "Hisss!!";
        }

    }
}
