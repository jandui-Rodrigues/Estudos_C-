using Composicao;
using Heranca;

class Progam
{
    public static void Main()
    {
        var car = new Car
        {
            TopSpeed = 200,
            IsAutomatic = true,
            NumberOfSeats = 5,
            Engine = new Engine
            {
                Horsepower = 200,
                Torque = 150,
                Capacity = 2000
            }
        };
        var server = new Server();
        server.StartServer();

        var ogre = new Ogre();
        Console.WriteLine($"Ogre Health: {ogre.Health}");
        var goblin = new Goblin();
        Console.WriteLine($"Goblin Health: {goblin.Health}");
        Console.WriteLine(Monster.Count);

    }
}


