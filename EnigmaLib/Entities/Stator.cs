using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnigmaLib.Base;
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

        public char ForwardCommutate(char letter) => commutationDict.GetValueOrDefault(letter);

        public char BackwardCommutate(char letter) => reversedCommutationDict.GetValueOrDefault(letter);


        public char[] GetRotorLine(bool isLeft = true) => isLeft ? leftRotorLine : rightRotorLine;


        public void SetCommutationConfig(Dictionary<char, char> commutationDict, Dictionary<char, char> reversedCommutationDict)
        {
            this.commutationDict = commutationDict;
            this.reversedCommutationDict = reversedCommutationDict;

            leftRotorLine = commutationDict.Keys.ToArray();
            rightRotorLine = commutationDict.Values.ToArray();
        }
    }
}
