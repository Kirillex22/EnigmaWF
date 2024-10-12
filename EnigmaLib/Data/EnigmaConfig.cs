using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaLib
{
    public class EnigmaConfig
    {
        public Dictionary<char, char> CommutationPanelConfig { get; set; }

        public Dictionary <string, int> EngineConfig { get; set; }

        public Dictionary <char, char> ReflectorConfig { get; set; }
    }
}
