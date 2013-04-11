using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataRacing.Common
{
    public class Car
    {
        public int LanePosition { get; private set; }
        public int Distance { get; private set; }

        public Car(int lanePosition, int distance)
        {
            this.LanePosition = lanePosition;
            this.Distance = distance;
        }
    }
}
