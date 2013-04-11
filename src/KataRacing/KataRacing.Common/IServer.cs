using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataRacing.Common
{
    /// <summary>
    /// Интерфейс сервера, обрабатывающего всю логику гонки
    /// </summary>
    public interface IServer
    {
        /// <summary>
        /// Подключение к игре
        /// </summary>
        /// <returns>При успешном подключении возвращает информацию о гонке (трасса, участники и т.д.)</returns>
        RaceWorld ConnectToGame();
    }
}
