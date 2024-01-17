Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US", false);

int one = 1;

// Operators
int some = 5 + 5;
int sub = 5 - 5;
int mult = 5 * 5;
int div = 5 / 5;
int mod = 5 % 5;

// Increment

int increment = one++;
int decrement = one--;
some += one;
sub -= one;
mult *= one;
div /= one;
mod %= one;


//Adição
int a = 50, b = 50;
int result1 = a + b;
Console.WriteLine(a + " + " + b + " = " + result1);

//Subtração
int c = 77, d = 21;
int result2 = c - d;
Console.WriteLine(c + " - " + d + " = " + result2);

//Multiplicação
int e = 5, f = 5;
int result3 = e * f;
Console.WriteLine(e + " * " + f + " = " + result3);

//divisão
int g = 90, h = 9;
int result4 = g / h;
Console.WriteLine(g + " / " + h + " = " + result4);

//módulo
int i = 36, j = 7;
int result5 = i % j;
Console.WriteLine("O resto da divisão de "+i+" por "+j+" é "+result5);

int newResult = ((a + b) * c);
Console.WriteLine("((" + a + " + " + b + ") * " + c + ") = " + newResult);


// Operadores de comparação
// == igual, != diferente, > maior, < menor, >= maior ou igual, <= menor ou igual

// Operadores lógicos
// && and, || or, ! not