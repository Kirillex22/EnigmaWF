using static EnigmaLib.Constants;

namespace EnigmaLib
{
    class Reflector : IReflectable
    {
        public string Name = Empty;

        private Dictionary<char, char> reflectionDict;

        public char Reflect(char letter) => reflectionDict.GetValueOrDefault(letter);

        public void SetReflectionConfig(Dictionary<char, char> reflectionDict)
        {
            this.reflectionDict = reflectionDict;
        }
    }
}
