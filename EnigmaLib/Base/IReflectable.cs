using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaLib
{
    /// <summary>
    /// Контракт, обязывающий обладать свойством преобразования символа в парный для него.
    /// </summary>
    public interface IReflectable
    {
        /// <summary>
        /// Производит преобразования символа на рефлекторе.
        /// </summary>
        /// <param name="letter">Символ для преобразования</param>
        /// <returns></returns>
        public char Reflect(char letter);

        /// <summary>
        /// Устанавливает словарь для операции отражения на рефлекторе
        /// </summary>
        /// <param name="reflectionDict">Словарь рефлектора</param>
        public void SetReflectionConfig(Dictionary<char, char> reflectionDict);

        public char[] GetRotorLine();
    }
}
