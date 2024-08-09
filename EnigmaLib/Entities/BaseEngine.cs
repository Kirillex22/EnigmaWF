using EnigmaLib.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EnigmaLib.Constants;
using static EnigmaLib.Languages;

namespace EnigmaLib
{
    public class BaseEngine : IEngine
    {
        public char[]? Key { get; set; }
        public string Lang { get; set; } = English;

        private Stator? stator;

        private Reflector? reflector; //как избавиться от жесткой привязки к типам??

        private List<Rotor> rotors;
        
        public BaseEngine() => rotors = new List<Rotor>();
        
        public void PlaceRotor(Rotor rotor) => rotors.Add(rotor);

        public void PlaceStator(Stator stator) => this.stator = stator;

        public void PlaceReflector(Reflector reflector) => this.reflector = reflector;

        /// <summary>
        /// Производит коммутацию между парой ICommutatable слева-направо
        /// </summary>
        /// <param name="letter">Символ для коммутации</param>
        /// <param name="outputRotor">Ротор, правая сторона которого будет являться источником символа letter</param>
        /// <param name="inputRotor">Ротор, левая сторона которого будет являться destination символа letter</param>
        /// <returns>Символ, полученный на правой стороне ротора inputRotor</returns>
        private char LeftCommutation(char letter, ICommutatable outputRotor, ICommutatable inputRotor)
        {
            char[] outputLine = outputRotor.GetRotorLine(false);
            char[] inputLine = inputRotor.GetRotorLine(true);

            char nextRotorInputLetter = inputLine[Array.IndexOf(outputLine, letter)];

            return inputRotor.ForwardCommutate(nextRotorInputLetter);
        }

        /// <summary>
        /// Производит коммутацию между парой ICommutatable справа-налево
        /// </summary>
        /// <param name="letter">Символ для коммутации</param>
        /// <param name="outputRotor">Ротор, левая сторона которого будет являться источником символа letter</param>
        /// <param name="inputRotor">Ротор, правая сторона которого будет являться destination символа letter</param>
        /// <returns>Символ, полученный на левой стороне ротора inputRotor</returns>
        private char RightCommutation(char letter, ICommutatable outputRotor, ICommutatable inputRotor)
        {
            char[] outputLine = outputRotor.GetRotorLine(true);
            char[] inputLine = inputRotor.GetRotorLine(false);

            char nextRotorInputLetter = inputLine[Array.IndexOf(outputLine, letter)];

            return inputRotor.BackwardCommutate(nextRotorInputLetter);
        }

        /// <summary>
        /// Производит отражение и коммутацию справа-налево
        /// </summary>
        /// <param name="letter">Символ для отражения -> коммутации</param>
        /// <param name="outputInputRotor">Ротор, являющийся источником letter и destination</param>
        /// <param name="reflector">Рефлектор</param>
        /// <returns>Символ, полученный на левой стороне ротора outputInputRotor</returns>
        private char RightLeftReflection(char letter, ICommutatable outputInputRotor, IReflectable reflector)
        {
            char[] outputLine = outputInputRotor.GetRotorLine(false);
            char[] reflectorLine = reflector.GetRotorLine();

            char nextRotorInputLetter = reflector.Reflect(reflectorLine[Array.IndexOf(outputLine, letter)]);

            return outputInputRotor.BackwardCommutate(outputLine[Array.IndexOf(reflectorLine, nextRotorInputLetter)]);

        }

        /// <summary>
        /// Производит установку подключа для каждого из роторов
        /// </summary>
        /// <param name="key"></param>
        public void Init()
        {
            int k = rotors.Count() - 1;

            for (int i = 0; i <= k; i++)
            {
                rotors[i].SetInitialState();
                rotors[i].SetKey(Key[k - i]);
            }

        }

        /// <summary>
        /// Производит согласованный поворот системы роторов (может повернуться как один, так и несколько за одно обращение)
        /// </summary>
        private void SystemTurn()
        {
            int k = rotors.Count() - 1;

            rotors[0].Turn(false);

            for (int i = 0; i <= k; i++)
            {
                if (rotors[i].RoundCounter == StartPoint)
                    rotors[(i + 1) % k].Turn(false);
                else
                    break;
            }
        }

        /// <summary>
        /// Прямой обход роторов
        /// </summary>
        /// <param name="currentLetter">Текущий символ, полученный при последнем преобразовании</param>
        /// <returns>Преобразованный после обхода роторов слева-направо символ</returns>
        private char FrwdProp(char currentLetter)
        {
            for (int i = 0; i < rotors.Count() - 1; i++)
            {
                currentLetter = LeftCommutation(currentLetter, rotors[i], rotors[i + 1]);
            }

            return currentLetter;
        }

        /// <summary>
        /// Обратный обход роторов
        /// </summary>
        /// <param name="currentLetter">Текущий символ, полученный при последнем преобразовании</param>
        /// <returns>Преобразованный после обхода роторов справа-налево символ</returns>
        private char BckwrdProp(char currentLetter)
        {
            for (int i = rotors.Count() - 1; i > 0; i--)
            {
                currentLetter = RightCommutation(currentLetter, rotors[i], rotors[i - 1]);
            }

            return currentLetter;
        }
        /// <summary>
        /// Получение конечного символа путем полного прямого и обратного преобразования.
        /// </summary>
        /// <param name="currentLetter">Входной символ</param>
        /// <param name="logging">Если True - в консоль выводятся изменения состояний каждого из роторов на протяжении всех преобразований.</param>
        /// <returns>Преобразованный символ</returns>
        public char GetNewLetter(char currentLetter, bool logging)
        {
            SystemTurn();

            if (logging)
            {
                foreach (var i in rotors) i.Print(false);
            }

            currentLetter = LeftCommutation(currentLetter, stator, rotors[0]);// передача сигнала со статора на правую сторону первого ротора 
            currentLetter = FrwdProp(currentLetter);//прямой обход            
            currentLetter = RightLeftReflection(currentLetter, rotors[rotors.Count() - 1], reflector);//отражение на рефлекторе          
            currentLetter = BckwrdProp(currentLetter);//обратный обход         
            currentLetter = RightCommutation(currentLetter, rotors[0], stator);//передача сигнала на статор

            return currentLetter;//возврат значения
        }

        /// <summary>
        /// Разворачивает словарь, делая ключи - значениями, а значения - ключами.
        /// </summary>
        /// <param name="initial">Текущий словарь для ротора/статора</param>
        /// <returns>Инвертированный словарь</returns>
        private Dictionary<char, char> ReverseDict(Dictionary<char, char> initial)
        {
            var reversed = new Dictionary<char, char>();
            foreach (var pair in initial)
            {
                reversed.Add(pair.Value, pair.Key);
            }
            return reversed;
        }

        /// <summary>
        /// Производит установку языка для всех элементов машинки
        /// </summary>
        /// <param name="Lang">Язык из класса Constants</param>
        public void SetLang(string Lang)
        {
            switch (Lang)
            {
                case Russian:
                    stator.SetCommutationConfig(RuRDictStd, RuRDictStd);
                    reflector.SetReflectionConfig(RuRDictRef);

                    foreach (Rotor i in rotors)
                    {
                        i.SetCommutationConfig(RuRDict, ReverseDict(RuRDict));
                        i.Key = RuSTDKey;
                    }

                    this.Lang = Russian;
                    break;

                case English:
                    stator.SetCommutationConfig(EnRDictStd, EnRDictStd);
                    reflector.SetReflectionConfig(EnRDictRef);

                    foreach (Rotor i in rotors)
                    {
                        i.SetCommutationConfig(EnRDict, ReverseDict(EnRDict));
                        i.Key = EnSTDKey;
                    }

                    this.Lang = English;
                    break;

                default:
                    break;
            }
        }
    }
}
