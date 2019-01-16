using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.interfaces
{
    interface IHuntWaterAndLand
    {
            /// <summary>
            /// set a property to state weather the animal can eat in land
            /// </summary>
            bool haveToEatInLand { get; set; }

            /// <summary>
            /// set a property to state weather the animal can hunt in water
            /// </summary>
            /// <returns></returns>
            string HuntInWater();     
    }
}
