using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaLib
{
    public interface IEngine
    {
        public char[] Key { get; set; }
        public string Lang { get; set; }
        public char[]? GetRotorLineByName(string name);
        public void Init();
        public char GetNewLetter(char currentLetter, bool logging);
        public void SetLang(string Lang);
    }
}
