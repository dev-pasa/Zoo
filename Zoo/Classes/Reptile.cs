using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Classes;

namespace Zoo.Classes
{
    public abstract class Reptile : Mammal
    {   
        public virtual string Length { get; set; }

        public abstract bool LayEggs { get; set; }
    }
}
