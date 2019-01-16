using System;
using System.Collections.Generic;
using System.Text;


namespace Zoo.Classes
{
    public abstract class Cats : Mammal
    {             
        /// <summary>
        /// create a virtual property that gives the claw length
        /// </summary>
        public virtual int ClawLength { get; set; }

        /// <summary>
        /// define whether the animal hunts
        /// </summary>
        /// <returns></returns>
        public abstract string Hunts();

        /// <summary>
        /// abstract property to describe if the animal can climb trees
        /// </summary>
        /// <returns></returns>
        public abstract string ClimbsTree();

        /// <summary>
        /// abstract property to state how many cubs it gives birth to in average
        /// </summary>
        /// <returns></returns>
        public abstract string GiveBirth();

    }
}
