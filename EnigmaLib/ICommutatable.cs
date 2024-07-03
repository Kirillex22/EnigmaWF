using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaLib
{
    internal interface ICommutatable
    {
        public char[] GetRotorLine(bool isLeft);
        public char ForwardCommutate(char letter);
        public char BackwardCommutate(char letter);

    }
}
