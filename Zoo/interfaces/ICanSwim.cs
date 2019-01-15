using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.interfaces
{
    interface ICanSwim
    {
        /// <summary>
        /// can swim in water
        /// </summary>
        /// <returns></returns>
        string Swim();

        /// <summary>
        /// Can dry off by themselves
        /// </summary>
        /// <returns></returns>
        string DryOff();
    }
}
