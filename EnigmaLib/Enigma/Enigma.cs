using EnigmaLib.Base;
using static EnigmaLib.Constants;

namespace EnigmaLib
{
    public class BaseEnigma
    {
        private IEngine engine;

        public IChangeable Commutator { get; set; } 

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

        public BaseEnigma(IEngineBuilder builder)
        {
            engine = builder
                .BuildStator()
                .BuildRotor()
                .BuildRotor()
                .BuildRotor()
                .BuildReflector()
                .GetEngine();
        }

        public char Encrypt(char letter) => engine.GetNewLetter(letter, false);

        public string Encrypt(string message)
        {
            string result = Empty;
            message.ToList().ForEach(letter => {
                var currentLetter = Commutator.Commutate(letter);
                result += Commutator.Commutate(engine.GetNewLetter(currentLetter, false));
            });
            return result;
        }

        public void ConnectWires(char letterA, char letterB) => Commutator.CreatePair(letterA, letterB);

        public void DisconnectWires(char letterA, char letterB) => Commutator.DeletePair(letterA, letterB);
    }
}