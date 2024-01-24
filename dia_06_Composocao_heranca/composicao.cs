// A composição é um conceito fundamental da POO que nos permite definir que uma classe mais complexa é composta por outras classes, em regra, mais simples. Isso nos possibilita separar conceitos e desacoplar funções, tornando nossas classes mais concisas e modulares!

namespace Composicao
{
   class Engine
    {
        public int Horsepower { get; set; }
        public int Torque { get; set; }
        public int Capacity { get; set; }
        public bool IsStarted { get; set; }

        public void Start()
        {
            if (IsStarted)
                Console.WriteLine("The engine is already started!");
            else
                IsStarted = true;
        }

        public void Stop()
        {
            if (!IsStarted)
                Console.WriteLine("The engine is already stopped!");
            else
                IsStarted = false;
        }
    }
    class Car
{
    public double TopSpeed { get; set; }
    public bool IsAutomatic { get; set; }
    public int NumberOfSeats { get; set; }
    public Engine Engine { get; set; } = new Engine();

    public void Drive(double distanceKm, double speed)
    {
        if (speed > TopSpeed)
            Console.WriteLine("Your car can't go that fast!");
        else if (!Engine.IsStarted)
            Console.WriteLine("Your car isn't turned on!");
        else
        {
            var time = distanceKm / speed;
            Console.WriteLine($"You arrived in {time} hours.");
        }
    }

    public void StartEngine() => Engine.Start();

    public void StopEngine() => Engine.Stop();
}
  public class Db
    {
        public void StartDb()
        {
            Console.WriteLine("Starting database...");
        }
        public void StopDb()
        {
            Console.WriteLine("Stopping database...");
        }
    }

    public class Server
    {
        public Db DataBase { get; set;} = new Db();

        public void StartServer()
        {
            DataBase.StartDb();
            Console.WriteLine("Starting server...");
            Console.WriteLine("Server started!");
        }

    }


}