using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaLib.Base
{
    /// <summary>
    /// Контракт, обязывающий обладать возможностью поворота.
    /// </summary>
    internal interface ITurnable
    {
        /// <summary>
        /// Изменяет состояние ITurnable
        /// </summary>
        /// <param name="isInitial">Если True - поворот не задает смещение счетчика проворотов (нужно для начальной настройки ротора). Иначе - счетчик инкрементируется.</param>
        public void Turn(bool isInitial);
    }
}
