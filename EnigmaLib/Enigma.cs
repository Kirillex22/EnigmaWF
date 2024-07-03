using static EnigmaLib.Constants;

namespace EnigmaLib
{
    public class Enigma
    {
        private Engine engine = new();

        private string key = Default;


        public Enigma()
        {
            SetKey(key);
        }


        public void SetKey(string key)
        {
            this.key = key;
            Reboot();
        }


        public char Encrypt(char letter)
        {
            return engine.GetNewLetter(letter, false);
        }


        public string Encrypt(string message)
        {
            string result = Empty;

            foreach (char i in message)
            {
                var res = engine.GetNewLetter(i, false);
                Console.WriteLine($"ENCRYPTED: {res}\n");
                result += res;
            }
                

            return result;
        }


        public void Reboot()
        {
            char[] NewKey = key.ToCharArray();
            engine.Init(NewKey);
        }


        public void SwithLang(string Lang)
        {
            engine.SetLang(Lang);
        }


        public string GetLang()
        {
            return engine.Lang;
        }

        public char[] GetCurrentRotorLine(string name)
        {
            return engine.GetRotorLineByName(name);
        }

    }
}