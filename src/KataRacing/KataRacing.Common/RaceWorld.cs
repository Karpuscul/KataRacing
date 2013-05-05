using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataRacing.Common
{
    /// <summary>
    /// Контекст гонки, все необходимая информация для проведения гонки (карта трассы, участники и т.д.)
    /// </summary>
    public class RaceWorld
    {
        private readonly List<Car> cars;

        /// <summary>
        /// Карта трассы
        /// </summary>
        public Map Map { get; private set; }

        /// <summary>
        /// Участники гонки
        /// </summary>
        public IReadOnlyList<Car> Cars
        {
            get { return this.cars; }
        }

        /// <summary>
        /// Создает контекст гонки с заданными параметрами
        /// </summary>
        /// <param name="map">Карта трассы</param>
        /// <param name="cars">Участники гонки</param>
        public RaceWorld(Map map, IEnumerable<Car> cars)
        {
            this.Map = map;
            this.cars = new List<Car>(cars);
        }
    }
}
