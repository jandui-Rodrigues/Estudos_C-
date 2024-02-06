using System.Collections;

namespace ListaC;

public class TestList
{
    public List<int> numbers = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    public List<int> numbersTwo = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    public Queue<int> queue = new() {}; // Fila
    public Stack<int> stack = new() {}; // Pilha
    public SortedList<int, string> sortedList = new() {}; // Lista ordenada

    public List<string> names = new() { "Maria", "João", "Rebeca", "Ana", "Paulo", "Lucas", "Carla", "Mariana", "Pedro", "Ricardo" };
    public TestList(string[] args)
    {
    }
    public void List()
    {
        numbers.Add(4); // Adiciona um número no final da lista
        numbers.Insert(0, 0); // Adiciona um número no início da lista
        numbers.RemoveAt(5); // Remove o número na posição 5
        numbers = numbers.Where(n => n % 2 == 0).ToList(); // Filtra todos os números pares
        numbers.Remove(4); // Remove o número 4
        numbers.Sort(); // Ordena a lista
        numbers.Reverse(); // Inverte a ordem da lista
        numbers.Clear(); // Limpa a lista
        numbers.AddRange(numbersTwo); // Adiciona uma lista de números no final da lista
        numbers.InsertRange(0, new List<int> { 0, 0, 0, 0, 0 }); // Adiciona uma lista de números no início da lista
        numbers.RemoveRange(5, 5); // Remove 5 números a partir da posição 5
        numbers.RemoveAll(n => n % 2 == 0); // Remove todos os números pares
        numbers.ForEach(n => Console.WriteLine(n)); // Imprime todos os números
        numbers = numbers.Select(n => n * 2).ToList(); // Multiplica todos os números por 2
        numbers = numbers.OrderBy(n => n).ToList(); // Ordena a lista
        numbers = numbers.OrderByDescending(n => n).ToList(); // Ordena a lista de forma decrescente
        numbers = numbers.Skip(5).ToList(); // Pula os 5 primeiros números
        numbers = numbers.Take(5).ToList(); // Pega os 5 primeiros números
        numbers = numbers.Distinct().ToList(); // Remove os números duplicados
        numbers = numbers.Intersect(numbersTwo).ToList(); // Retorna os números que estão nas duas listas
        numbers = numbers.Except(numbersTwo).ToList(); // Retorna os números que estão na primeira lista e não estão na segunda
        numbers = numbers.Union(numbersTwo).ToList(); // Retorna os números das duas listas sem repetição
        numbers = numbers.Concat(numbersTwo).ToList(); // Retorna a concatenação das duas listas
        numbers = numbers.Zip(numbersTwo, (n1, n2) => n1 + n2).ToList(); // Retorna a soma dos números das duas listas
    }
    public void Queue()
    {
        queue.Enqueue(1); // Adiciona um número no final da fila
        queue.Dequeue(); // Remove o número no início da fila
        queue.Peek(); // Retorna o número no início da fila
        queue.Clear(); // Limpa a fila
        queue = new Queue<int>(numbers); // Adiciona uma lista de números na fila
        queue = new Queue<int>(numbersTwo); // Adiciona uma lista de números na fila
    }
    public void Stack()
    {
        stack.Push(1); // Adiciona um número no início da pilha
        stack.Pop(); // Remove o número no início da pilha
        stack.Peek(); // Retorna o número no início da pilha
        stack.Clear(); // Limpa a pilha
        stack = new Stack<int>(numbers); // Adiciona uma lista de números na pilha
        stack = new Stack<int>(numbersTwo); // Adiciona uma lista de números na pilha
    }
    public void SortedList()
    {
        sortedList.Add(1, "Maria"); // Adiciona um número e um nome na lista ordenada
        sortedList.Remove(1); // Remove o número 1
        sortedList.Clear(); // Limpa a lista
        sortedList = new SortedList<int, string>(numbers.Zip(names, (n, name) => new { n, name }).ToDictionary(x => x.n, x => x.name)); // Adiciona uma lista de números e nomes na lista ordenada
    }

}

