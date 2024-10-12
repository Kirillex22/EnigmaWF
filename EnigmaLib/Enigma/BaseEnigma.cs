using EnigmaLib.Base;
using static EnigmaLib.Constants;

namespace EnigmaLib
{
    public class BaseEnigma : IEnigma
    {
        private IEngine _engine;

        public IChangeable _commutator;

        private string key;

        public string Key 
        {
            get { return key; } 
            set 
            {
                key = value;
                _engine.Key = value.ToArray();
                _engine.Init();
            } 
        }

        private string lang;
        public string Lang
        {
            get { return lang; }
            set
            {
                lang = value;
                _engine.SetLang(value);
            }
        }

        public void PlaceCommutator(IChangeable commutator)
        {
            _commutator = commutator;
        }

        public void PlaceEngine(IEngine engine)
        {
            _engine = engine;
        }

        public char Encrypt(char letter) => _engine.GetNewLetter(letter, false);

        public string Encrypt(string message)
        {
            string result = Empty;
            message.ToList().ForEach(letter => {
                var currentLetter = _commutator.Commutate(letter);
                result += _commutator.Commutate(_engine.GetNewLetter(currentLetter, false));
            });
            return result;
        }
    }
}