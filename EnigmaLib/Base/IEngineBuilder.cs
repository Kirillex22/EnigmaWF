using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaLib.Base
{
    public interface IEngineBuilder
    {
        public IEngineBuilder BuildStator();
        public IEngineBuilder BuildRotor();
        public IEngineBuilder BuildReflector();
        public IEngine GetEngine();
    }
}
