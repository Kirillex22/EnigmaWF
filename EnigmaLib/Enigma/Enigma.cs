using static EnigmaLib.Constants;

namespace EnigmaLib
{
    public class Enigma
    {
        private IEngine engine;

        private string key;
        public string Key 
        {
            get { return key; } 
            set 
            {
                key = value;
                engine.Key = value.ToArray();
                engine.Init();
            } 
        }

        private string lang;
        public string Lang
        {
            get { return lang; }
            set
            {
                lang = value;
                engine.SetLang(value);
            }
        }

        public Enigma(IEngine engine) => this.engine = engine;

        public char Encrypt(char letter)
        {
            return engine.GetNewLetter(letter, false);
        }

        public string Encrypt(string message)
        {
            string result = Empty;
            message.ToList().ForEach(letter => result += engine.GetNewLetter(letter, false));
            return result;
        }
    }
}