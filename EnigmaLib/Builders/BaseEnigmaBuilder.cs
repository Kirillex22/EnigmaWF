using EnigmaLib.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EnigmaLib.Builders
{
    public class BaseEnigmaBuilder : IEnigmaBuilder
    {
        private IEnigma _enigma;
        private EnigmaConfig _config;

        public BaseEnigmaBuilder()
        {
            _enigma = new BaseEnigma();
            _config = JsonSerializer.Deserialize<EnigmaConfig>(File.ReadAllText("C:\\Users\\ziabr\\source\\repos\\WindowsFormsApp2\\EnigmaLib\\EnigmaConfig.json"))!;
        }

        public IEnigmaBuilder BuildEngine()
        { 
            var engineCfg = _config.EngineConfig;
            var rotorsCount = engineCfg["rotorsCount"];
            var offsetByFullRound = engineCfg["offsetByFullRound"];

            var builder = new BaseEngineBuilder()
                .BuildStator()
                .BuildOffset(offsetByFullRound);

            for (int i = 0; i < rotorsCount; i++)
            {
                builder.BuildRotor();
            }

            builder.BuildReflector();

            _enigma.PlaceEngine(builder.GetEngine());

            return this;
        }
        public IEnigmaBuilder BuildCommutationPanel()
        {
            var cp = new Commutator(_config.CommutationPanelConfig);
            _enigma.PlaceCommutator(cp);
            return this;
        }

        public IEnigma GetEnigma() => _enigma;
    }
}
