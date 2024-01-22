namespace ClassString
{
    public class TestandoString
    {
        public static string Teste()
        {
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite seu sobrenome:");
            string sobrenome = Console.ReadLine();
            string nomeCompleto = nome + " " + sobrenome;
            return nomeCompleto;
        }

        public static string StringConCat()
        {
            string nome = "João";
            string sobrenome = "Silva";
            string nomeCompleto = string.Concat(nome, " ", sobrenome);
            return nomeCompleto;
        }
        /// <summary>
        /// Split a string into an array of strings
        /// </summary>
        /// <param name="phase"></param>
        /// <returns></returns>
        public static string[] StringSplit(string phase)
        {
            string[] words = phase.Split(' ');
            return words;
        }

        public static string  StringReplace(string phase, string oldWord, string newWord)
        {
            string newPhase = phase.Replace(oldWord, newWord);
            return newPhase;
        }

        public static int StringIndexOf(string phase, string word)
        {
            int index = phase.IndexOf(word);
            return index;
        }

        public static string RemovePalavraPeloIndex(string phase, int index, int numberCharactersToRemove)
        {
            string newPhase = phase.Remove(index, numberCharactersToRemove);
            return newPhase;
        }

        public static bool StringContains(string phase, string word)
        {
            bool contains = phase.Contains(word);
            return contains;
        }

        public static string StringJoin(string[] words)
        {
            string phase = string.Join(" ", words);
            return phase;
        }
    }
}