using EnigmaLib.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaLib.Builders
{
    public class BaseEngineBuilder : IEngineBuilder
    {
        private BaseEngine _engine;

        public BaseEngineBuilder() => _engine = new BaseEngine();

        public void BuildStator()
        {
            var st = new Stator();
            _engine.PlaceStator(st);
        }
        public void BuildRotor()
        {
            var rt = new Rotor();
            _engine.PlaceRotor(rt);
        }
        public void BuildReflector()
        {
            var rf = new Reflector();
            _engine.PlaceReflector(rf);
        }

        public IEngine GetEngine() => _engine;
    }
}
