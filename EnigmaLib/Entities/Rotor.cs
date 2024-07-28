using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnigmaLib.Base;
using static EnigmaLib.Constants;
using static EnigmaLib.Languages;

namespace EnigmaLib
{
    class Rotor : ICommutatable, ITurnable, IPrintable
    {
        /// <summary>
        /// Используется в качестве метки ротора.
        /// </summary>
        public string Name = Empty;

        private char[] leftRotorLine;

        private char[] rightRotorLine;

        private Dictionary<char, char> commutationDict;

        private Dictionary<char, char> reversedCommutationDict;

        /// <summary>
        /// Часть от общего ключа, соответствующая данному ротору.
        /// </summary>
        public char? Key;

        /// <summary>
        /// Счетчик прокрутки ротора.
        /// </summary>
        public int RoundCounter = StartPoint;
        
        /// <summary>
        /// Выводит в консоль состояние ротора на момент обращения.
        /// </summary>
        /// <param name="isInit">В случае, если запрос ассоциируется с initial поворотом, ничего не выводится.</param>
        public void Print(bool isInit)
        {
            if (!isInit)
            {
                Console.WriteLine($"NAME: {Name}");
                Console.WriteLine($"ROUND_COUNTER: {RoundCounter}");
                Console.Write("L_ROTOR_STATE: ");
                leftRotorLine.ToList().ForEach(x => Console.Write($"{x} "));
                Console.Write("\nR_ROTOR_STATE: ");
                rightRotorLine.ToList().ForEach(x => Console.Write($"{x} "));
                Console.WriteLine("END\n");
            } 
        }

        //обновляет состояние правой стороны ротора
        private void UpdateRight()
        {
            var upd = new List<char>();
            leftRotorLine.ToList().ForEach(x => upd.Add(commutationDict[x]));
            rightRotorLine = upd.ToArray();
        }

        /// <summary>
        /// Устанавливает часть ключа как ключ для текущего ротора.
        /// </summary>
        /// <param name="Key">Символ, соответствующий части ключа</param>
        public void SetRotorKey(char Key)
        {
            RoundCounter = StartPoint;

            this.Key = Key;
            int leftDisplacement = Array.IndexOf(leftRotorLine, Key);

            while (leftDisplacement != 0)
            {
                Turn(true);
                leftDisplacement--;
            }

            UpdateRight();
        }


        private void Counter()
        {
            if (RoundCounter == leftRotorLine.Length)
                RoundCounter = StartPoint;
            else
                RoundCounter++;
        }

        /// <summary>
        /// Изменяет состояние ротора.
        /// </summary>
        /// <param name="isInitial">Если True - поворот не задает смещение счетчика проворотов (нужно для начальной настройки ротора). Иначе - счетчик инкрементируется.</param>
        public void Turn(bool isInitial)
        {
            if (!isInitial) Counter();

            char startLetter = leftRotorLine[StartPoint];

            //не работает со значениями StartPoint != 0
            for (int i = 0; i < leftRotorLine.Length; i++)
            {
                if (i == leftRotorLine.Length - 1)
                    leftRotorLine[i] = startLetter;
                else
                    leftRotorLine[i] = leftRotorLine[i + 1];
            }

            UpdateRight();

            //Print(isInitial);
        }

        /// <summary>
        /// Прямое распространение сигнала по ротору (т.е. слева-направо при нормальном расположении реальной Enigma)
        /// </summary>
        /// <param name="letter">Символ для внутренней коммутации.</param>
        /// <returns></returns>
        public char ForwardCommutate(char letter) => commutationDict.GetValueOrDefault(letter);

        /// <summary>
        /// Обратное распространение сигнала по ротору (т.е. справа-налево при нормальном расположении реальной Enigma)
        /// </summary>
        /// <param name="letter">Символ для внутренней коммутации.</param>
        /// <returns></returns>
        public char BackwardCommutate(char letter) => reversedCommutationDict.GetValueOrDefault(letter);

        /// <summary>
        /// Необходим для получения текущего состояния ротора.
        /// </summary>
        /// <param name="isLeft">Если True - возвращается char[], соответствующий текущему положению левой стороны ротора. Иначе - char[] с правой стороной.</param>
        /// <returns>Возвращает массив символов ротора со смещением относительно начальной позиции (ключа) на данный момент</returns>
        public char[] GetRotorLine(bool isLeft) => isLeft ? leftRotorLine : leftRotorLine;

        /// <summary>
        /// Устанавливает конфигурацию ротора (т.е. словарь коммутации и обратный словарь коммутации)
        /// </summary>
        /// <param name="commutationDict">Словарь коммутации (нужен для прямого распространения)</param>
        /// <param name="reversedCommutationDict">Обратный словарь коммутации (нужен для обратного распостранения)</param>
        public void SetCommutationConfig(Dictionary<char, char> commutationDict, Dictionary<char, char> reversedCommutationDict)
        {
            this.commutationDict = commutationDict;
            this.reversedCommutationDict = reversedCommutationDict;

            leftRotorLine = commutationDict.Keys.ToArray();
            rightRotorLine = commutationDict.Values.ToArray();
        }

        /// <summary>
        /// Изменяет состояние ротора путем сброса до стандартного начального положенения (при этом значение ключа необходимо изменить).
        /// </summary>
        public void SetInitialState()
        {
            leftRotorLine = commutationDict.Keys.ToArray();
            rightRotorLine = commutationDict.Values.ToArray();
        }
    }
}
