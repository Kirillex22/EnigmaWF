using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static EnigmaLib.Constants;
using static EnigmaLib.Languages;

namespace EnigmaLib
{
    class Rotor : ICommutatable, ITurnable
    {
        public string Name = Empty;

        private char[] leftRotorLine;

        private char[] rightRotorLine;

        private Dictionary<char, char> commutationDict;

        private Dictionary<char, char> reversedCommutationDict;

        public char? Key;

        public int RoundCounter = StartPoint;

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

        private void UpdateRight()
        {
            var upd = new List<char>();
            leftRotorLine.ToList().ForEach(x => upd.Add(commutationDict[x]));
            rightRotorLine = upd.ToArray();
        }


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


        public void Turn(bool isInitial)
        {
            if (!isInitial) Counter();

            char startLetter = leftRotorLine[StartPoint];

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


        public char ForwardCommutate(char letter) => commutationDict.GetValueOrDefault(letter);


        public char BackwardCommutate(char letter) => reversedCommutationDict.GetValueOrDefault(letter);


        public char[] GetRotorLine(bool isLeft) => isLeft ? leftRotorLine : leftRotorLine;


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
