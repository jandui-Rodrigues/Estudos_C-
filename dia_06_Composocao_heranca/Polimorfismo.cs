namespace Polimorfismo;

interface IProduto
{
    string Nome { get; set; }
    float Preco { get; set; }
}

interface ICarrinho
{
    List<Produto> Produtos { get; set; }
    void AdicionarProduto(Produto produto);
    void MostrarProdutos();
    void CalcularTotal();
}

public class Produto : IProduto
{
    public string Nome { get; set;}
    public float Preco { get; set; }

    public Produto(string nome, float preco)
    {
        Nome = nome;
        Preco = preco;
    }
}

public class Livro : Produto
{
    public string Autor;
    public bool TemDesconto;

    public Livro(string nome, float preco, string autor, bool temDesconto): base(nome, preco)
    {
        Autor = autor;
        TemDesconto = temDesconto;
    }
}



public class Carrinho : ICarrinho
{
    public List<Produto> Produtos { get; set; }

    public Carrinho()
    {
        Produtos = new List<Produto>();
    }


    public void AdicionarProduto(Produto produto)
    {
        this.Produtos.Add(produto);
    }

    public void MostrarProdutos()
    {
        foreach (var produto in Produtos)
        {
            Console.WriteLine($"Produto: {produto.Nome} - Preço: {produto.Preco}");
        }
    }

    public void CalcularTotal()
    {
        float total = 0;
        foreach (var produto in Produtos)
        {
            total += produto.Preco;
        }
        Console.WriteLine($"Total: {total}");
    }

}

public class Polimorfismo
{
    public static void Executar()
    {
        // Instanciando um objeto da classe Produto
        Produto produto = new ("Caneta", 2.5f);

        // Instanciando um objeto da classe Livro
        Produto livro = new Livro("Game of Thrones", 49.9f, "George R. R. Martin", true);

        // Instanciando um objeto da classe Produto
        var carrinho = new Carrinho();
        carrinho.AdicionarProduto(produto);
        carrinho.AdicionarProduto(livro);
        carrinho.AdicionarProduto(new Produto("Caderno", 9.9f));
        carrinho.AdicionarProduto(new Produto("Borracha", 4.5f));
        carrinho.AdicionarProduto(new Produto("Lapis", 1.5f));

        carrinho.MostrarProdutos();
        carrinho.CalcularTotal();
    }
}