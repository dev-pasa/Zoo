using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Classes;

namespace Zoo.Classes
{
    public abstract class Mammal
    {
        /// <summary>
        /// create an abstract property that sets the age
        /// </summary>
        public abstract int Age { get; set; }

        /// <summary>
        /// abstract property name to define name
        /// </summary>
        public abstract string Name { get; set; }

        /// <summary>
        /// define the food it eats
        /// </summary>
        /// <returns></returns>
        public abstract string Food();
        
        /// <summary>
        /// define the sound it makes
        /// </summary>
        /// <returns></returns>
        public virtual string Sound()
        {
            return "Animal Sound";
        }

        /// <summary>
        /// create virtual Sleep method
        /// </summary>
        /// <returns></returns>
        public virtual string Sleep()
        {
            return "Sleep 10 hours";
        }
    }
}
