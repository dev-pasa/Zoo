using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.interfaces
{
    interface IHuntWaterAndLand
    {
            bool haveToEatInLand { get; set; }

            string HuntInWater();     
    }
}
