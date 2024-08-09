using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaLib.Base
{
    public interface IEngineBuilder
    {
        public void BuildStator();
        public void BuildRotor();
        public void BuildReflector();
        public IEngine GetEngine();
    }
}
