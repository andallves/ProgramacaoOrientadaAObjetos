using System;
using System.Collections.Generic;

class Pessoa
{
    public string nome;
    public string cpf;
    public short idade;
    public bool vacinado;

    public Pessoa(string _nome, string _cpf, short _idade, bool _vacinado)
    {
        nome = _nome;
        cpf = _cpf;
        idade = _idade;
        vacinado = _vacinado;
    } 
}


class Funcionario : Pessoa
{
    protected string matricula;
    protected string cnpj;
    public List<Pessoa> cadastrados = new List<Pessoa>();

    public Funcionario(string _nome, string _cpf, short _idade, bool _vacinado, string _matricula, string _cnpj) : base(_nome, _cpf, _idade, _vacinado)
    {
        matricula = _matricula;
        cnpj = _cnpj;
    }

    public void Cadastrar(Pessoa pessoa) {
        cadastrados.Add(pessoa);
    }
}


namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa cidadao = new Pessoa("Carlos", "000.000.000-00", 24, true);
             
            Funcionario funcionario1 = new Funcionario("Daniel", "000.000.000-00", 25, true, "09987434", "00.000.000/0000-00");
            funcionario1.Cadastrar(cidadao);
            Console.WriteLine(funcionario1.cadastrados[0]);
        }
    }
}