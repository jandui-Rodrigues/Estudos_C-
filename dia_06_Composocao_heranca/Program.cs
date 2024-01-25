using Composicao;
using Heranca;
using Intefaces;
using Abstrac;

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
        // serverI.Start();
        
        Instrument[] instruments = new Instrument[3];
        instruments[0] = new Guitar();
        instruments[1] = new Piano();
        instruments[2] = new Bateria();

        void PlayInstrument(Instrument instrument)
        {
            
            Console.WriteLine($"Playing {instrument.Type}");
            instrument.PlayInstrument();
            
        }
        for(int index = 0; index < instruments.Length; index += 1)
        {
            PlayInstrument(instruments[index]);
        }

    }
}


