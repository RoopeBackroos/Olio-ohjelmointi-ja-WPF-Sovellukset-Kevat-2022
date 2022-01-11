using System;
using System.Collections.Generic;
using System.Text;

namespace Muuntaja
{
    class Muuntaja
    {
        public static float KmToMiles(float km)
        {
            float mailiarvo = 0.62137f;
            return km * mailiarvo;
        }
    }
}
