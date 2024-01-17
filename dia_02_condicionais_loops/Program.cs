using System;

// Trasformação entre tipos (casting)

//casting implicito

int someIntNumber = 98;
long someLongNumber = someIntNumber;

int intResult = 5/2;

Console.WriteLine(intResult);

// casting explicito, usando a sintaxe () dizemos que queremos fazer um casting explicito

long longNumber = 516;
// (int) intNumber = longNumber; // ou 
// Se for possivel converter o valor, o casting é feito, caso contrario, ele retorna um erro
int intConvertNumber = Convert.ToInt32(longNumber);

Console.WriteLine(intConvertNumber);

// convertendo string para int

string stringNumber = "123";
int intStringNumber = Int32.TryParse(stringNumber, out int result) ? result : 0;

// ===============================================
// estruturas de repetição

int countWhile = 0;

while (countWhile > 0)
{
    Console.WriteLine(countWhile);
    countWhile--;
}

for(int count = 0; count > 0; count--)
{
    Console.WriteLine(count);
}

string[] names = new string[] { "Hulk", "Thor", "Loki" };
foreach (string name in names)
{
    string nameConsole = Console.ReadLine();
    if (nameConsole == name)
    {
        Console.WriteLine("Acertou");
        break;
    }
    else
    {
        Console.WriteLine("Errou");
        Console.WriteLine(name[0]);
    }
}

