using QuartaAtividade.Entities.Enums;

namespace QuartaAtividade.Entities;

public class Cidadao : Pessoa
{
    
    private StatusVacina _vacinado = StatusVacina.NãoVacinado;
  

    public Cidadao(string nome, string cpf, int idade) : base (nome, idade, cpf)
    {}

    public Cidadao(string nome, string cpf, int idade, string telefone, string email) : base (nome, idade, cpf, telefone, email)
    {}

    public void Vacinar()
    {
        _vacinado = StatusVacina.Vacinado;
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