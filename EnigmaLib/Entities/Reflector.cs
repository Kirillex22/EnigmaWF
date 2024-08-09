using static EnigmaLib.Constants;

namespace EnigmaLib
{
    public class Reflector : IReflectable
    {
        public string Name = Empty;

        private char[] leftRotorLine;

        private Dictionary<char, char> reflectionDict;

        public char Reflect(char letter) => reflectionDict.GetValueOrDefault(letter);
        public char[] GetRotorLine() => leftRotorLine;
        public void SetReflectionConfig(Dictionary<char, char> reflectionDict)
        {
            this.reflectionDict = reflectionDict;
            leftRotorLine = reflectionDict.Keys.ToArray();
        }
    }
}
