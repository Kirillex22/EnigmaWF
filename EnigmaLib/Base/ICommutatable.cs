using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaLib
{
    /// <summary>
    /// Контракт, обязывающий обладать свойствами внутренней коммутации (т.е. быть функцией char -> char в пределах методов ForwardCommutate и BackwardCommutate).
    /// </summary>
    internal interface ICommutatable
    {
        /// <summary>
        /// Позволяет получить текущее внутреннее состояние ICommutatable в виде массива char[].
        /// </summary>
        /// <param name="isLeft">Если Если True - возвращается char[], соответствующий текущему положению левой стороны ICommutatable. Иначе - char[] с правой стороной.</param>
        /// <returns></returns>
        public char[] GetRotorLine(bool isLeft);

        /// <summary>
        /// Прямая коммутация символа слева-направо
        /// </summary>
        /// <param name="letter">Символ для преобразования</param>
        /// <returns></returns>
        public char ForwardCommutate(char letter);

        /// <summary>
        /// Обраная коммутация символа справа-налево
        /// </summary>
        /// <param name="letter">Символ для преобразования</param>
        /// <returns></returns>
        public char BackwardCommutate(char letter);

        /// <summary>
        /// Устанавливает конфигурацию элемента (т.е. словарь коммутации и обратный словарь коммутации)
        /// </summary>
        /// <param name="commutationDict">Словарь коммутации (нужен для прямого распространения)</param>
        /// <param name="reversedCommutationDict">Обратный словарь коммутации (нужен для обратного распостранения)</param>
        public void SetCommutationConfig(Dictionary<char, char> commutationDict, Dictionary<char, char> reversedCommutationDict);

        /// <summary>
        /// Изменяет состояние элемента путем сброса до стандартного начального положенения (при этом значение ключа необходимо изменить).
        /// </summary>
    }
}
