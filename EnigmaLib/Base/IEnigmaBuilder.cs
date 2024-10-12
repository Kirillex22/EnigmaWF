using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaLib.Base
{
    public interface IEnigmaBuilder
    {
        public IEnigmaBuilder BuildEngine();
        public IEnigmaBuilder BuildCommutationPanel();
        public IEnigma GetEnigma();
    }
}
