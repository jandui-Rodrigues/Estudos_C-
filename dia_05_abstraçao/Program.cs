class Rocket
{
  string Name { get; set; }
  int Fuel { get; set }
  decimal Price { get; set; }

  public Rocket(string name, decimal price)
  {
    Name = name;
    Fuel = 0;
    Price = price;
  }
   public int FuelAsPercentage
    {
        get { return _fuel * 100 / _maxFuel; }
        set {
            if (value > 100 || value < 0)
                throw new ArgumentOutOfRangeException();

            _fuel = (value * _maxFuel) / 100;
        }
    }
}

public static class Trybe
{
    public static void Main()
    {}
    public static string[] students = { "Luiza", "Bruno", "Patrícia", "Tiago" };

    public static string[] Students
    {
        get { return students; }
        set { students = value; }
    }

    public static int NumberOfStudents
    {
        get { return students.Length; }
    }

    public static bool IsStudent(string name)
    {
        return Array.Exists(students, s => s == name);
    }

    public static void PrintStudents()
    {
        Console.WriteLine(string.Join(", ", students));
    }
}
Trybe.Students = new string[] { "Leticia", "Silvio" };

Trybe.PrintStudents(); // "Leticia, Silvio"