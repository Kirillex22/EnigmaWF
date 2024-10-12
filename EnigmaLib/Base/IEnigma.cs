using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaLib
{
    public interface IEnigma
    {
        public string Lang { get; set; }
        public string Key { get; set; }
        public char Encrypt(char letter);

        public string Encrypt(string message);

        public void PlaceEngine(IEngine engine);

        public void PlaceCommutator(IChangeable changeable);
    }
}
