using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnigmaLib.Base;
using static EnigmaLib.Constants;
using static EnigmaLib.Languages;

namespace EnigmaLib
{
    public class Engine
    {
        public char[] Key { get; set; }

        private Stator stator;

        private Reflector reflector;

        private List<Rotor> rotors;

        public string Lang = English;

        public Engine()
        {
            stator = new Stator();
            reflector = new Reflector();

            rotors = new List<Rotor>() {
                new Rotor(),
                new Rotor(),
                new Rotor()
            };

            stator.Name = "Stator";
            rotors[0].Name = "Right";
            rotors[1].Name = "Middle";
            rotors[2].Name = "Left";
            reflector.Name = "Reflector";

            SetLang(Lang);
        }

        /// <summary>
        /// Позволяет получить левую сторону ротора по его имени
        /// </summary>
        /// <param name="name">Имя ротора</param>
        /// <returns></returns>
        public char[]? GetRotorLineByName(string name)
        {
            foreach(var i in rotors)
            {
                if (i.Name == name) return i.GetRotorLine(true);
            }

            return null;
        }
        private char LeftRotorCommutation(char letter, ICommutatable outputRotor, ICommutatable inputRotor)
        {
            char[] outputLine = outputRotor.GetRotorLine(false);
            char[] inputLine = inputRotor.GetRotorLine(true);

            char nextRotorInputLetter = inputLine[Array.IndexOf(outputLine, letter)];

            return inputRotor.ForwardCommutate(nextRotorInputLetter);
        }


        private char RightRotorCommutation(char letter, ICommutatable outputRotor, ICommutatable inputRotor)
        {
            char[] outputLine = outputRotor.GetRotorLine(true);
            char[] inputLine = inputRotor.GetRotorLine(false);

            char nextRotorInputLetter = inputLine[Array.IndexOf(outputLine, letter)];

            return inputRotor.BackwardCommutate(nextRotorInputLetter);
        }

        /// <summary>
        /// Производит установку подключа для каждого из роторов
        /// </summary>
        /// <param name="key"></param>
        public void Init(char[] key)
        {
            Key = key;

            int k = rotors.Count() - 1;

            for (int i = 0; i <= k; i++)
            {
                rotors[i].SetInitialState();
                rotors[i].SetRotorKey(key[k - i]);
            }
                
        }


        private void Roll()
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
        /// Получение конечного символа путем полного прямого и обратного преобразования.
        /// </summary>
        /// <param name="letter">Входной символ</param>
        /// <param name="logging">Если True - в консоль выводятся изменения состояний каждого из роторов на протяжении всех преобразований.</param>
        /// <returns>Преобразованный символ</returns>
        public char GetNewLetter(char letter, bool logging)
        {
            Roll();

            if(logging)
            {
                foreach (var i in rotors) i.Print(false);
            }

            char fRes = LeftRotorCommutation(letter, stator, rotors[0]); //legacy
            char sRes = LeftRotorCommutation(fRes, rotors[0], rotors[1]);
            char tRes = LeftRotorCommutation(sRes, rotors[1], rotors[2]);
            char refRes = LeftRotorCommutation(tRes, rotors[2], reflector);
            char foRes = RightRotorCommutation(refRes, reflector, rotors[2]);
            char fiRes = RightRotorCommutation(foRes, rotors[2], rotors[1]);
            char siRes = RightRotorCommutation(fiRes, rotors[1], rotors[0]);

            return RightRotorCommutation(siRes, rotors[0], stator); //
        }

        private Dictionary<char, char> ReverseDict(Dictionary<char, char> initial)
        {
            var reversed = new Dictionary<char, char>();

            foreach(var pair in initial)
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
