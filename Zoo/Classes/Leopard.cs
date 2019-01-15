using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class Leopard : Cats
    {
        public string Print { get; set; } = "Leopard Print";

        public override string Name { get; set; } = "The fast Leopard";


        public override int Age { get; set; } = 9;

        public override int ClawLength { get; set; } = 5;
        public override string Food()
        {
            return "Deers and hogs";
        }
        public override string Sound()
        {
            return "Hiss and growl!!";
        }
        public override string Hunts()
        {
            return "I hunt by myself";
        }

        //abstract method
        public override string ClimbsTree()
        {
            return "I can run and climb trees";
        }

        //abstract method
        public override string GiveBirth()
        {
            return "Four cubs are born";
        }
    }
}
