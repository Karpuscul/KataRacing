using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataRacing.Common
{
    /// <summary>
    /// Контекст гонки
    /// </summary>
    public class RaceWorld
    {
        private List<Car> cars;

        public Map Map { get; private set; }

        public IReadOnlyList<Car> Cars
        {
            get { return this.cars; }
        }

        public RaceWorld(Map map, IEnumerable<Car> cars)
        {
            this.Map = map;
            this.cars = new List<Car>(cars);
        }
    }
}
