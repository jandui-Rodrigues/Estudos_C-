using Composicao;
using Heranca;
using Intefaces;

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
        // var server = new Server();
        // server.StartServer();
        IStarted serverI = new ServerI();
        serverI.Start();

    }
}


