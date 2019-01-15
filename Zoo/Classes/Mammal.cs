using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Classes;

namespace Zoo.Classes
{
    public abstract class Mammal
    {
        public abstract int Age { get; set; }
        public abstract string Name { get; set; }

        public abstract string Food();
        
        public virtual string Sound()
        {
            return "Animal Sound";
        }
    }
}
