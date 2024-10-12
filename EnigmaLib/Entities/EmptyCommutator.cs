using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaLib
{
    public class EmptyCommutator : IChangeable
    {
        public char Commutate(char letter)
        {
            return letter;
        }

        public void CreatePair(char letterA, char letterB)
        {
            throw new NotImplementedException();
        }

        public void DeletePair(char letterA, char letterB)
        {
            throw new NotImplementedException();
        }
    }
}
