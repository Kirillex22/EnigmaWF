namespace EnigmaLib
{
    public class Languages
    {
        public char[] EnRLine = new char[]
        {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h',
                'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p',
                'q', 'r', 's', 't', 'u', 'v', 'w', 'x',
                'y', 'z', ' ', '.', '!', '?', ',', '"',
                '-', ':'
        };

        public char[] RuRLine = new char[]
        {
                'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж',
                'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о',
                'п', 'р', 'с', 'т', 'у', 'х', 'ц', 'ч',
                'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я',
                ' ', '.', '!', '?', ',', '"', '-', ':'
        };

        public Dictionary<char, char> EnRDict = new Dictionary<char, char>()
        {
            {'a', '-'}, {'b', 'y'}, {'c', 'x'}, {'d', 'w'}, {'e', 'v'},
            {'f', 'u'}, {'g', 't'}, {'h', 's'}, {'i', 'r'}, {'j', 'q'},
            {'k', 'p'}, {'l', 'o'}, {'m', 'n'}, {'n', 'm'}, {'o', 'l'},
            {'p', 'k'}, {'q', 'j'}, {'r', 'i'}, {'s', 'h'}, {'t', 'g'},
            {'u', 'f'}, {'v', 'e'}, {'w', 'd'}, {'x', 'c'}, {'y', 'b'},
            {'z', ':'}, {' ', '.'}, {'.', ' '}, {'!', '?'}, {'?', '!'},
            {',', '"'}, {'"', ','}, {'-', 'a'}, {':', 'z'}
        };

        public Dictionary<char, char> RuRDict = new Dictionary<char, char>()
        {
            {'а', '-'}, {'б', 'э'}, {'в', 'ь'}, {'г', 'г'}, {'д', 'ы'},
            {'ё', 'щ'}, {'ж', 'ш'}, {'з', 'ч'}, {'и', 'ц'}, {'й', 'х'},
            {'к', 'у'}, {'л', 'т'}, {'м', 'с'}, {'н', 'р'}, {'о', 'п'},
            {'п', 'о'}, {'р', 'н'}, {'с', 'м'}, {'т', 'л'}, {'у', 'к'},
            {'х', 'й'}, {'ц', 'и'}, {'ч', 'з'}, {'ш', 'ж'}, {'щ', 'ё'},
            {'ъ', 'е'}, {'ы', 'д'}, {'ь', 'в'}, {'э', 'б'}, {'я', ':'},
            {' ', '.'}, {'.', ' '}, {'!', '?'}, {'?', '!'}, {',', '"'},
            {'"', ','}, {'-', 'а'}, {':', 'я'}, {'е', 'ъ'}
        };

        public Dictionary<char, char> EnRDictStd = new Dictionary<char, char>()
        {
            {'a', 'a'}, {'b', 'b'}, {'c', 'c'}, {'d', 'd'}, {'e', 'e'},
            {'f', 'f'}, {'g', 'g'}, {'h', 'h'}, {'i', 'i'}, {'j', 'j'},
            {'k', 'k'}, {'l', 'l'}, {'m', 'm'}, {'n', 'n'}, {'o', 'o'},
            {'p', 'p'}, {'q', 'q'}, {'r', 'r'}, {'s', 's'}, {'t', 't'},
            {'u', 'u'}, {'v', 'v'}, {'w', 'w'}, {'x', 'x'}, {'y', 'y'},
            {'z', 'z'}, {' ', ' '}, {'.', '.'}, {'!', '!'}, {'?', '?'},
            {',', ','}, {'"', '"'}, {'-', '-'}, {':', ':'}
        };

        public Dictionary<char, char> RuRDictStd = new Dictionary<char, char>()
        {
            {'а', 'а'}, {'б', 'б'}, {'в', 'в'}, {'г', 'г'}, {'д', 'д'},
            {'ё', 'ё'}, {'ж', 'ж'}, {'з', 'з'}, {'и', 'и'}, {'й', 'й'},
            {'к', 'к'}, {'л', 'л'}, {'м', 'м'}, {'н', 'н'}, {'о', 'о'},
            {'п', 'п'}, {'р', 'р'}, {'с', 'с'}, {'т', 'т'}, {'у', 'у'},
            {'х', 'х'}, {'ц', 'ц'}, {'ч', 'ч'}, {'ш', 'ш'}, {'щ', 'щ'},
            {'ъ', 'ъ'}, {'ы', 'ы'}, {'ь', 'ь'}, {'э', 'э'}, {'я', 'я'},
            {'ю', 'ю'}, {' ', ' '}, {'.', '.'}, {'!', '!'}, {'?', '?'},
            {',', ','}, {'"', '"'}, {'-', '-'}, {':', ':'}, {'е', 'е'}
        };

        public Dictionary<char, char> EnRDictRef = new Dictionary<char, char>()
        {
            {'a', 'v'}, {'b', 'm'}, {'c', 'w'}, {'d', 's'}, {'e', 'e'},
            {'f', 'n'}, {'g', '-'}, {'h', 'q'}, {'i', '!'}, {'j', 'j'},
            {'k', 'u'}, {'l', ':'}, {'m', 'b'}, {'n', 'f'}, {'o', 'o'},
            {'p', 'p'}, {'q', 'h'}, {'r', 'r'}, {'s', 'd'}, {'t', 't'},
            {'u', 'k'}, {'v', 'a'}, {'w', 'c'}, {'x', 'x'}, {'y', 'y'},
            {'z', '?'}, {' ', '"'}, {'.', ','}, {'!', 'i'}, {'?', 'z'},
            {',', '.'}, {'"', ' '}, {'-', 'g'}, {':', 'l'}
        };

        public Dictionary<char, char> RuRDictRef = new Dictionary<char, char>()
        {
            {'а', 'б'}, {'б', 'а'}, {'в', 'м'}, {'г', 'ц'}, {'д', 'д'},
            {'ё', 'ё'}, {'ж', '-'}, {'з', 'э'}, {'и', 'и'}, {'й', 'р'},
            {'к', 'к'}, {'л', 'л'}, {'м', 'в'}, {'н', 'т'}, {'о', 'у'},
            {'п', 'е'}, {'р', 'й'}, {'с', 'с'}, {'т', 'н'}, {'у', 'о'},
            {'х', 'ч'}, {'ц', 'г'}, {'ч', 'х'}, {'ш', 'ш'}, {'щ', 'щ'},
            {'ъ', 'ь'}, {'ы', 'ы'}, {'ь', 'ъ'}, {'э', 'з'}, {'я', '?'},
            {' ', '"'}, {'.', '.'}, {'!', 'ю'}, {'?', 'я'}, {',', ':'},
            {'"', ' '}, {'-', 'ж'}, {':', ','}, {'ю', '!'}, {'е', 'п'}
        };

        public char RuSTDKey = 'а';

        public char EnSTDKey = 'a';
    }

    
    interface SpinDetail
    {
        public char Commutate(char letter);

        public char[] GetRotorLine();

        public void SetRotorDict(Dictionary<char, char> RotorDict);

        public void Lang(char[] RotorLine, Dictionary<char, char> RotorDict, char Key);

    }
    
    class Rotor : SpinDetail
    {
        private Languages languages = new Languages();
        private char[] RotorLine;
        private Dictionary<char, char> RotorDict;
        public char Key;
        public int RoundCounter = 0;

        public Rotor()
        {
            RotorLine = languages.EnRLine;
            RotorDict = languages.EnRDict;
            Key = languages.EnSTDKey;
        }

        public void SetRotorKey(char Key)
        {
            RoundCounter = 0;

            if (Array.IndexOf(RotorLine, Key) == -1)
                throw new ArgumentException("Language is different");
            this.Key = Key;
            int displacement = Array.IndexOf(RotorLine, Key);

            while (displacement != 0)
            {
                Turn(1);
                displacement--;
            }
        }

        private void SetRoundCounter()
        {
            if (RoundCounter == RotorLine.Length)
                RoundCounter = 0;
            else
                RoundCounter++;
        }

        public void Turn()
        {
            try
            {
                char startLetter = RotorLine[0];
                SetRoundCounter();

                for (int i = 0; i < RotorLine.Length; i++)
                {
                    if (i == RotorLine.Length - 1)
                        RotorLine[i] = startLetter;
                    else
                        RotorLine[i] = RotorLine[i + 1];
                }
            }

            catch
            {
                throw new ArgumentException("Rotor's turn error");
            }

        }

        public void Turn(int freedomVal)
        {
            if (freedomVal == 1)
            {
                try
                {
                    char startLetter = RotorLine[0];


                    for (int i = 0; i < RotorLine.Length; i++)
                    {
                        if (i == RotorLine.Length - 1)
                            RotorLine[i] = startLetter;
                        else
                            RotorLine[i] = RotorLine[i + 1];
                    }
                }

                catch
                {
                    throw new ArgumentException("Key setting error");
                }
            }
                         
        }

        public char Commutate(char letter)
        {
            try
            {
                return RotorDict.GetValueOrDefault(letter);
            }

            catch
            {
                throw new ArgumentException("Letter getting error");
            }

        }

        public void SetRotorDict(Dictionary<char, char> RotorDict)
        {
            this.RotorDict = RotorDict;
        }

        public char[] GetRotorLine()
        {
            return RotorLine;
        }

        public void Lang(char[] RotorLine, Dictionary<char, char> RotorDict, char Key)
        {
            this.RotorLine = RotorLine;
            this.RotorDict = RotorDict;
            this.Key = Key;
        }

        public void SetRotorLineDefault(string lang)
        {
            if (lang == "ru")
                this.RotorLine = languages.RuRLine;
            else if (lang == "en")
                this.RotorLine = languages.EnRLine;
        }
    }

    class Engine
    {
        public char[] Key = new char[3];
        private SpinDetail InputRotor = new Rotor();
        private SpinDetail OutputRotor = new Rotor();
        private SpinDetail Reflector = new Rotor();
        private Dictionary<char, char> RotorDictRef;
        private Dictionary<char, char> RotorDictStd;
        private List<Rotor> Rotors = new List<Rotor>()
        {
            new Rotor(), new Rotor(), new Rotor()
        };
        public string lang;
        private Languages languages = new Languages();

        public Engine()
        {
            RotorDictRef = languages.EnRDictRef;
            RotorDictStd = languages.EnRDictStd;
            lang = "en";
        }

        private char RotorCommutation(char letter, SpinDetail outputRotor, SpinDetail inputRotor)
        {
            char[] outputLine = outputRotor.GetRotorLine();
            char[] inputLine = inputRotor.GetRotorLine();

            char commutatedLetter = outputRotor.Commutate(letter);
            int letterIndex = Array.IndexOf(outputLine, commutatedLetter);
            char result = inputLine[letterIndex];

            return result;
        }

        public void Init()
        {
            Rotors[0].SetRotorKey(Key[2]);
            Rotors[1].SetRotorKey(Key[1]);
            Rotors[2].SetRotorKey(Key[0]);
            Reflector.SetRotorDict(RotorDictRef);
            InputRotor.SetRotorDict(RotorDictStd);
            OutputRotor.SetRotorDict(RotorDictStd);
        }

        private void TurnRotor()
        {
            Rotors[0].Turn();
            if (Rotors[0].RoundCounter == 0)
            {
                Rotors[1].Turn();
                if (Rotors[1].RoundCounter == 0)
                    Rotors[2].Turn();
            }
        }

        public char GetNewLetter(char letter)
        {
            TurnRotor();
            try
            {
                char firstRes = RotorCommutation(letter, InputRotor, Rotors[0]);
                char secondRes = RotorCommutation(firstRes, Rotors[0], Rotors[1]);
                char thirdRes = RotorCommutation(secondRes, Rotors[1], Rotors[2]);
                char reflectedRes = RotorCommutation(thirdRes, Rotors[2], Reflector);
                char fourthRes = RotorCommutation(reflectedRes, Reflector, Rotors[2]);
                char fifthRes = RotorCommutation(fourthRes, Rotors[2], Rotors[1]);
                char sixthRes = RotorCommutation(fifthRes, Rotors[1], Rotors[0]);
                char seventhRes = RotorCommutation(sixthRes, Rotors[0], InputRotor);

                return seventhRes;
            }

            catch
            {
                throw new ArgumentException("RotorCommutation error");
            }

        }

        public void SetLang(string lang)
        {
            switch (lang)
            {
                case "ru":
                    RotorDictStd = languages.RuRDictStd;
                    RotorDictRef = languages.RuRDictRef;
                    InputRotor.Lang(languages.RuRLine, languages.RuRDict, languages.RuSTDKey);
                    OutputRotor.Lang(languages.RuRLine, languages.RuRDict, languages.RuSTDKey);
                    Reflector.Lang(languages.RuRLine, languages.RuRDict, languages.RuSTDKey);
                    foreach (Rotor i in Rotors)
                        i.Lang(languages.RuRLine, languages.RuRDict, languages.RuSTDKey);
                    this.lang = "ru";
                    break;

                case "en":
                    RotorDictStd = languages.EnRDictStd;
                    RotorDictRef = languages.EnRDictRef;
                    InputRotor.Lang(languages.EnRLine, languages.EnRDict, languages.EnSTDKey);
                    OutputRotor.Lang(languages.EnRLine, languages.EnRDict, languages.EnSTDKey);
                    Reflector.Lang(languages.EnRLine, languages.EnRDict, languages.EnSTDKey);
                    foreach (Rotor i in Rotors)
                        i.Lang(languages.EnRLine, languages.EnRDict, languages.EnSTDKey);
                    this.lang = "en";
                    break;

                default:
                    break;
            }
        }

        public void Reboot()
        {
            foreach (Rotor i in Rotors)
                i.SetRotorLineDefault(lang);
        }
    }

    public class Enigma
    {
        private Engine engine = new Engine();

        public void SetKey(string Key)
        {
            engine.Reboot();
            engine.Key = Key.ToCharArray();
            engine.Init();
        }

        public char Ecnrypt(char letter)
        {
            return engine.GetNewLetter(letter);
        }

        public void SwithLang(string lang)
        {
            engine.SetLang(lang);
        }

        public string GetLang()
        {
            return engine.lang;
        }

    }
}