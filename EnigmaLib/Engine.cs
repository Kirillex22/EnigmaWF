using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static EnigmaLib.Constants;
using static EnigmaLib.Languages;

namespace EnigmaLib
{
    public class Engine
    {
        private char[] key;

        private Stator stator;

        private Stator reflector;

        private List<Rotor> rotors;

        public string Lang = English;

        public Engine()
        {
            stator = new Stator();
            reflector = new Stator();

            rotors = new List<Rotor>() {
                new Rotor(),
                new Rotor(),
                new Rotor()
            };

            key = new char[3];

            stator.Name = "Stator";
            rotors[0].Name = "Right";
            rotors[1].Name = "Middle";
            rotors[2].Name = "Left";
            reflector.Name = "Reflector";

            SetLang(Lang);
        }

        public char[] GetRotorLineByName(string name)
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


        public void Init(char[] key)
        {
            this.key = key;

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


        public char GetNewLetter(char letter, bool logging)
        {
            Roll();

            if(logging)
            {
                stator.Print(false);
                foreach (var i in rotors) i.Print(false);
                reflector.Print(false);
            }
            
            char fRes = LeftRotorCommutation(letter, stator, rotors[0]);
            char sRes = LeftRotorCommutation(fRes, rotors[0], rotors[1]);
            char tRes = LeftRotorCommutation(sRes, rotors[1], rotors[2]);
            char refRes = LeftRotorCommutation(tRes, rotors[2], reflector);
            char foRes = RightRotorCommutation(refRes, reflector, rotors[2]);
            char fiRes = RightRotorCommutation(foRes, rotors[2], rotors[1]);
            char siRes = RightRotorCommutation(fiRes, rotors[1], rotors[0]);

            return RightRotorCommutation(siRes, rotors[0], stator);
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
        public void SetLang(string Lang)
        {
            switch (Lang)
            {
                case Russian:
                    stator.SetCommuationConfig(RuRDictStd, RuRDictStd);
                    stator.Key = RuSTDKey;

                    reflector.SetCommuationConfig(RuRDictRef, ReverseDict(RuRDictRef));
                    reflector.Key = RuSTDKey;

                    foreach (Rotor i in rotors)
                    {
                        i.SetCommuationConfig(RuRDict, ReverseDict(RuRDict));
                        i.Key = RuSTDKey;
                    }
                                            
                    this.Lang = Russian;
                    break;

                case English:
                    stator.SetCommuationConfig(EnRDictStd, EnRDictStd);
                    stator.Key = EnSTDKey;

                    reflector.SetCommuationConfig(EnRDictRef, ReverseDict(EnRDictRef));
                    reflector.Key = EnSTDKey;

                    foreach (Rotor i in rotors)
                    {
                        i.SetCommuationConfig(EnRDict, ReverseDict(EnRDict));
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
