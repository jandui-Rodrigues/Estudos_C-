namespace Intefaces
{
    interface IGreeter
    {
        void SayGreeting(string greeting);
    }

    interface IStarted
    {
        void Start();
    }

    public interface IDatabase
    {
        public string GetByModel(string model);
    }

    public class MongoGateway : IDatabase
    {
        public string GetByModel(string model)
        {
            return $"Mongo: {model}";
        }
    }

    public class SqlGateway : IDatabase
    {
        public string GetByModel(string model)
        {
            return $"SQL: {model}";
        }
    }

    public class ServerI : IStarted, IDatabase
    {
        public void Start()
        {
            Console.WriteLine("Server started");
        }
        public string GetByModel(string database)
        {
            return $"{database}";
        }
    }

}

// Interfaces são muito úteis em contextos nos quais precisamos isolar funcionalidades das suas implementações. Considere, por exemplo, que tenhamos dois bancos de dados, um em Mongo e outro em SQL.

// Se estivermos criando uma API que precisa acessar um banco de dados e acessar um valor de uma classe Car através do modelo do carro, por exemplo, poderemos criar uma interface que represente a camada de acesso ao banco