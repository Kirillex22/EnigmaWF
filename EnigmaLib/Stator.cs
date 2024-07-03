using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static EnigmaLib.Constants;
using static EnigmaLib.Languages;

namespace EnigmaLib
{
    class Stator : ICommutatable
    {
        public string Name = Empty;

        private char[] leftRotorLine;

        private char[] rightRotorLine;

        private Dictionary<char, char> commutationDict;

        private Dictionary<char, char> reversedCommutationDict;

        public char? Key;

        public void Print(bool isInit)
        {
            if (!isInit)
            {
                Console.WriteLine($"NAME: {Name}");
                Console.Write("L_ROTOR_STATE: ");
                leftRotorLine.ToList().ForEach(x => Console.Write($"{x} "));
                Console.Write("\nR_ROTOR_STATE: ");
                rightRotorLine.ToList().ForEach(x => Console.Write($"{x} "));
                Console.WriteLine("END\n");
            }
        }

        public char ForwardCommutate(char letter) => commutationDict.GetValueOrDefault(letter);

        public char BackwardCommutate(char letter) => letter;//reversedCommutationDict.GetValueOrDefault(letter);


        public char[] GetRotorLine(bool isLeft = true) => isLeft ? leftRotorLine : rightRotorLine;


        public void SetCommuationConfig(Dictionary<char, char> commutationDict, Dictionary<char, char> reversedCommutationDict)
        {
            this.commutationDict = commutationDict;
            this.reversedCommutationDict = reversedCommutationDict;

            leftRotorLine = commutationDict.Keys.ToArray();
            rightRotorLine = commutationDict.Values.ToArray();
        }


        public void SetInitialState()
        {
            leftRotorLine = commutationDict.Keys.ToArray();
            rightRotorLine = commutationDict.Values.ToArray();
        }
    }
}
