// Array tipo[] nome = new tipo[tamanho];

// Estrutura de dados que permite que diversos valores, de um mesmo tipo, sejam armazenados em uma única variável controlando os mesmos através de posições (índices) numerados a partir de 0.

int[] numbers = new int[5] { 1, 2, 3, 4, 5 };

int[] firstArrayNumbers = { 1, 2, 3, 4, 5 };

string[] names = new string[] { "Hulk", "Thor", "Loki" };

// Console.WriteLine(names[0]);

// array multiDimesional

int[,] arrayMulti = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

// array jagged

int[][] arrayJagged = new int[2][];
arrayJagged[0] = new int[3] { 1, 2, 3 };
arrayJagged[1] = new int[2] { 4, 5 };

// Console.WriteLine(arrayJagged[0][0]);

// // 3 dimesoes

int[,,] multiDimesionArray1 = new int[2, 3, 2] { { { 1, 2 }, { 3, 4 }, { 5, 6 } }, { { 7, 8 }, { 9, 10 }, { 11, 12 } } };
int [,,] multiDimesionalArray2 = new int[2, 2, 2] { { {1, 2}, { 3, 4}}, { {6, 6}, { 7, 9} } };

// // O array jagged precisa ser instanciado em partes. Primeiro instanciamos o array com 3 dimensões, depois instanciamos cada array dentro dele

string[][][] tripleJaggedArray = new string[3][][];

tripleJaggedArray[0] = new string[2][]; // { new string[2] { "A", "B"}, new string[2] { "C", "D" } };
tripleJaggedArray[0][0] = new string[2] { "A", "B" };
tripleJaggedArray[0][1] = new string[2] { "C", "D" };

Console.WriteLine(tripleJaggedArray[0][1][0]);


// Funções
// Funções são encapsulamentos de partes de código nomeadas que podem ser utilizadas e chamadas em diversas partes do código. Elas podem ter valores de entrada parametrizados e podem retornar um valor ou não.


// (Nive de Acessibilidade "Opcional") - Retorno - Nome (Parâmetros)
// { abertura
//  Corpo da função
// } fechamento

double CaulculateBMI(int weight, double height)
{
    double BMI = weight / (height * height);
    return BMI;
}

Console.WriteLine(CaulculateBMI(80, 1.80));

// Funções sem retorno

void PrintName(string name)
{
    Console.WriteLine(name);
}

// Exeçoes try/catch/finally
// Instrução que permite controlar as exceções que podem ser lançadas dentro de um bloco de código. Com isso, pode-se controlar o bloco de código a ser executada caso uma exceção seja lançada.

// try {} catch (Exception ex) { ex.Message }

// catch (DivideByZeroException ex) { ex.Message }

// lançando exeções
// throw new Exception("Mensagem");
// throw new NullReferenceExepetion("Message")

// finally { } - sempre executa

int divisibol(int a, int b)
{
    if (b == 0)
    {
        throw new DivideByZeroException("Não é possivel dividir por zero");
    }
    return a / b;
}

try
{
    // o try serve para tentar executar o código
    divisibol(10, 0);
}
catch (DivideByZeroException ex)
{
    // O catch serve para capturar a exeção
    // Essa forma de capturar a exeção serve para mostrar a mensagem de erro
    throw;
}
finally
{
    //O finally sempre executa
    Console.WriteLine("Fim da execução");
}