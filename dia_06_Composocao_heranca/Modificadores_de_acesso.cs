namespace Modificadores;

// public serve para deixa metodos e atributos visiveis para todo o projeto
public class RemedioGenerico
{
    // todas as suas hedeiras teram acesso e poderam modificar
    public string Formula { get; set; }
    public string Nome { get; set; }

    public RemedioGenerico(string formula, string nome)
    {
        Formula = formula;
        Nome = nome;
    }
}

public class RemedioPrivado
{
    // somente a classe que herda tera acesso, mas nao pode modificar
    private string Formula { get; set; }
    private string Nome { get; set; }

    public RemedioPrivado(string formula, string nome)
    {
        Formula = formula;
        Nome = nome;
    }
}

public class RemedioProtegido
{
    // somente a classe que herda tera acesso, mas nao pode modificar
    protected string Formula { get; set; }
    protected string Nome { get; set; }

    public RemedioProtegido(string formula, string nome)
    {
        Formula = formula;
        Nome = nome;
    }
}

public class RemedioProtegidoFilho : RemedioProtegido
{
    public RemedioProtegidoFilho(string formula, string nome) : base(formula, nome)
    {
    }
}