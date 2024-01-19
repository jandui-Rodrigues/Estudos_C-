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
    }
}