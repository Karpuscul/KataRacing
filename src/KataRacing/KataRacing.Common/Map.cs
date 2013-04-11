using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataRacing.Common
{
    public class Map
    {
        public int LanesCount { get; private set; }
        public int Length { get; private set; }

        public Map(int lanesCount, int length)
        {
            this.LanesCount = lanesCount;
            this.Length = length;
        }
    }
}
