using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaLib
{
    /// <summary>
    /// Контракт, обязывающий элемент обладать возможностью изменять связи между коммутирующими символами
    /// </summary>
    public interface IChangeable
    {
        public void CreatePair(char letterA, char letterB);
        public void DeletePair(char letterA, char letterB);
        public char Commutate(char letter);
    }
}
