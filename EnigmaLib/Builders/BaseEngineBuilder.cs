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

        public IEngineBuilder BuildStator()
        {
            var st = new Stator();
            _engine.PlaceStator(st);
            return this;
        }
        public IEngineBuilder BuildRotor()
        {
            var rt = new Rotor();
            _engine.PlaceRotor(rt);
            return this;
        }
        public IEngineBuilder BuildReflector()
        {
            var rf = new Reflector();
            _engine.PlaceReflector(rf);
            return this;
        }

        public IEngineBuilder BuildOffset(int offset)
        {
            _engine.PlaceOffsetByFullRound(offset);
            return this;
        }
        public IEngine GetEngine() => _engine;
    }
}
