using System;
using System.Collections.Generic;
using System.Text;


namespace Zoo.Classes
{
    public abstract class Cats : Mammal
    {             
        public virtual int ClawLength { get; set; }

        //abstract method
        public abstract string Hunts();

        //abstract method
        public abstract string ClimbsTree();

        //abstract method
        public abstract string GiveBirth();

    }
}
