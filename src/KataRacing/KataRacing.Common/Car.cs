using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataRacing.Common
{
    /// <summary>
    /// Информация об автомобиле на трассе
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Номер полосы на которой сейчас находится автомобиль
        /// </summary>
        public int LanePosition { get; private set; }

        /// <summary>
        /// Растояние от начала трассы
        /// </summary>
        public int Distance { get; private set; }

        /// <summary>
        /// Создает объект автомобиля с заданными параметрами
        /// </summary>
        /// <param name="lanePosition">Номер полосы на которой сейчас находится автомобиль</param>
        /// <param name="distance">Растояние от начала трассы</param>
        public Car(int lanePosition, int distance)
        {
            this.LanePosition = lanePosition;
            this.Distance = distance;
        }
    }
}
