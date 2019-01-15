using System;
using System.Collections.Generic;
using System.Text;


namespace Zoo.Classes
{
    public abstract class Cats : Mammal
    {

        public override int Age { get; set; } = 10;

        public override string Name { get; set; } = "Cat Family";
        
        public virtual int ClawLength { get; set; }

        public override string Food()
        {
            return "Cat Food";
        }
        public override string Sound()
        {
            return "Meoww!!";
        }

        //abstract method
        public abstract string Hunts();

        //abstract method
        public abstract string ClimbsTree();

        //abstract method
        public abstract string GiveBirth();

    }
}
