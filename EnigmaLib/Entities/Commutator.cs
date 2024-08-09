using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaLib
{
    public class Commutator : IChangeable
    {
        private Dictionary<char, char> container;

        public Commutator()
        {
            container = new Dictionary<char, char>();
        }
        public void CreatePair(char letterA, char letterB)
        {
            container.Add(letterA, letterB);
            container.Add(letterB, letterA);
        }

        public void DeletePair(char letterA, char letterB)
        {
            if (container[letterA] == letterB || container[letterB] == letterA)
            {
                container.Remove(letterA);
                container.Remove(letterB);
            }
            else
                throw new Exception("Wrong situation");
        }

        public char Commutate(char letter)
        {
            if (container.ContainsKey(letter))
            {
                return container[letter];
            }

            return letter;
        }
    }
}
