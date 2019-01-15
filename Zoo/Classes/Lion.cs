using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class Lion : Cats
    {
        public string Print { get; set; } = "Leopard Print";

        public override int Age { get; set; } = 14;

        public override string Name { get; set; } = "Lion King";

        public override int ClawLength { get; set; } = 6;

        public override string Food()
        {
            return "Buffallo and wilder beasts";
        }
        public override string Sound()
        {
            return "Big Roar!!";
        }
        
        public override string Hunts()
        {
            return "Hunt in a pack";
        }
       
        public override string ClimbsTree()
        {
            return "I king don't climb trees";
        }

        public override string GiveBirth()
        {
            return "Three cubs are born";
        }
    }
}
