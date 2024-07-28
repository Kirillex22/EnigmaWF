using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaLib.Base
{
    interface IPrintable
    {
        /// <summary>
        /// Выводит в консоль состояние элемента на момент обращения.
        /// </summary>
        /// <param name="isInitial">В случае, если запрос ассоциируется с initial поворотом, ничего не выводится.</param>
        public void Print(bool isInitial);
    }
}
