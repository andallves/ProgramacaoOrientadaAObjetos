using System;
using System.Collections.Generic;

namespace SegundaAtividade
{
    public class Funcionario : Pessoa
    {
        private int Id { get; }
        string Matricula { get; set; }
        string Cnpj { get; }
        public List<Pessoa> Cadastrados { get; private set; } = new List<Pessoa>();

        public override string ToString()
        {
            return "Funcionario: " + Nome + "\r\n"
                   + "Matricula: " + Matricula + "\r\n"
                   + "Pacientes cadastrados: " + "\r\n"
                   + ObterCadastrados();
        }

        public Pessoa ObterCadastrados()
        {
            foreach (var pessoa in Cadastrados)
            {
                return pessoa;
            }

            return null;
        }

        public Funcionario(string nome, string cpf, int idade, string matricula, string cnpj) : base(nome, cpf, idade)
        {
            Matricula = matricula;
            Cnpj = cnpj;
        }

        public void Cadastrar() {
            Console.Write("Nome: ");
            string nomeCidadao = Console.ReadLine();
            Console.Write("CPF: ");
            string cpfCidadao = Console.ReadLine();
            Console.Write("Idade: ");
            int idadeCidadao = int.Parse(Console.ReadLine());
            Pessoa cidadao = new Pessoa(nomeCidadao, cpfCidadao, idadeCidadao);
            Console.Write("Vaciná-lo? [s/n]: ");
            char vacinar = char.Parse(Console.ReadLine());

            if (vacinar == 's' || vacinar == 'S')
            {
                cidadao.Vacinar();
            }
            Cadastrados.Add(cidadao);
        }
    }
}