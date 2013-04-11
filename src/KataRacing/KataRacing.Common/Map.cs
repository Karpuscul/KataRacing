using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataRacing.Common
{
    /// <summary>
    /// Карта гонки
    /// </summary>
    public class Map
    {
        /// <summary>
        /// Количество полос движения на трассе
        /// </summary>
        public int LanesCount { get; private set; }

        /// <summary>
        /// Длинна трассы
        /// </summary>
        public int Length { get; private set; }

        /// <summary>
        /// Создает карту с заданными параметрами
        /// </summary>
        /// <param name="lanesCount">Количество полос движения на трассе</param>
        /// <param name="length">Длинна трассы</param>
        public Map(int lanesCount, int length)
        {
            this.LanesCount = lanesCount;
            this.Length = length;
        }
    }
}
