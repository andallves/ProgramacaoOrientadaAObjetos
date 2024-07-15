namespace TerceiraAtividade.Entities;

public class Cidadao
{
    public string Nome { get; }
    public int Idade { get; set; }
    private string _cpf;
    private bool _vacinado = false;
    public string? Telefone { get; set; }
    public string? Email { get; set; }

    public Cidadao() { }

    public Cidadao(string nome, string cpf, int idade)
    {
        Nome = nome;
        _cpf = cpf;
        Idade = idade;
    }

    public Cidadao(string nome, string cpf, int idade, string telefone, string email)
    {
        Nome = nome;
        _cpf = cpf;
        Idade = idade;
        Telefone = telefone;
        Email = email;
    }

    public void Vacinar()
    {
        _vacinado = true;
    }
        
    public string Cpf
    {   get { return _cpf; }
        set { _cpf = value; }
    }

    public override string ToString()
    {
        return "================================\r\n"
               + "Nome: " + Nome + "\r\n"
               + "Cpf: " + Cpf + "\r\n"
               + "Vacinado: " + _vacinado + "\r\n"
               + "================================";
    }
}