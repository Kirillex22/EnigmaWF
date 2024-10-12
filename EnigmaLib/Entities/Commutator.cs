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
        private Dictionary<char, char> _container;

        public Commutator(Dictionary<char, char> container)
        {
            container = container;
        }
        public void CreatePair(char letterA, char letterB)
        {
            _container.Add(letterA, letterB);
            _container.Add(letterB, letterA);
        }

        public void DeletePair(char letterA, char letterB)
        {
            if (_container[letterA] == letterB)
            {
                _container.Remove(letterA);
                _container.Remove(letterB);
            }
        }

        public char Commutate(char letter)
        {
            if (_container.ContainsKey(letter))
            {
                return _container[letter];
            }

            return letter;
        }
    }
}
