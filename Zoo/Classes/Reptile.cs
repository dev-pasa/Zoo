using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Classes;

namespace Zoo.Classes
{
    public abstract class Reptile : Mammal
    {   
        /// <summary>
        /// create virtual method to state the length
        /// </summary>
        public virtual string Length { get; set; }

        /// <summary>
        /// property to define the average eggs it can produce
        /// </summary>
        public abstract bool LayEggs { get; set; }
    }
}
