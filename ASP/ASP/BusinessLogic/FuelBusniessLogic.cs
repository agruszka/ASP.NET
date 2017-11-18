using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.BusinessLogic
{
    public class FuelBusniessLogic
    {
        public double CalculateAvgConsumption(int fuel, int distance)
        {
            double avg = (double)fuel / distance;
            return avg * 100;
        }
    }
}