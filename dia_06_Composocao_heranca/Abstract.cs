// abstrao algo que eu nao consigo construir
// concreto algo construido
// override sobrescrever
// redeonly somente leitura
//  classes abstratas, que são aquelas que não implementam todos os seus métodos e que, ao invés de serem implementadas diretamente, servem como ponto de partida para classes derivadas que, por sua vez, serão instanciadas.

namespace Abstrac;

public abstract class Instrument
{
    public string Type { get; set; } = "";
    public bool IsElectronic { get; set; } = false;
    public void PlayInstrument()
    {
        var instrument = GetType().Name.ToLower();
        Console.WriteLine($"the { instrument } is sounding");
    }
}

public class Guitar : Instrument
{
    public Guitar()
    {
        Type = "Guitar";
        IsElectronic = true;
    }
}

public class Piano : Instrument
{
    public Piano()
    {
        Type = "Piano";
        IsElectronic = false;
    }
}

public class Bateria: Instrument
{
    public Bateria()
    {
        Type = "Bateria";
        IsElectronic = false;
    }
}
