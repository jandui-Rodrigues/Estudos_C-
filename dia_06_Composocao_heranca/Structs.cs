// Structs são tipos de valor e não referência, tornando então possível criar uma espécie de “classe” simplificada com membros e métodos, e ainda assim armazenar sua instância como valor.

namespace Structs
{
    public struct Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
    }

    struct Coordinate
    {
        public double Latitude;
        public double Longitude;

        public Coordinate(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var pessoa = new Pessoa();
            Console.WriteLine(pessoa.Nome);
        }
    }
}