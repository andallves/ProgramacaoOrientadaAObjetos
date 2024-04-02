using System;

namespace SegundaAtividade
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Vamos começar!");
            Console.WriteLine("Primeiro preenche o formulário abaixo com as informações no funcionário: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("CPF: ");
            string cpf = Console.ReadLine();
            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.Write("Matricula da Empresa: ");
            string matricula = Console.ReadLine();
            Console.Write("CNPJ da Empresa: ");
            string cnpj = Console.ReadLine();
            Funcionario funcionario = new Funcionario(nome, cpf, idade, matricula, cnpj);
            
            Console.WriteLine();
            Console.WriteLine("Agora vamos cadastrar um pessoa para vacinar:");
            Console.WriteLine("Preenche o formulário abaixo com as informações do paciente: ");
            
            char continuar = 's';
            do
            {
                
                funcionario.Cadastrar();
                Console.WriteLine();
                Console.WriteLine("Cadastrar outro paciente? [s/n]");
                continuar = char.Parse(Console.ReadLine());
                
            } while (continuar == 's' || continuar == 'S');
            
            Console.WriteLine();
            Console.WriteLine(funcionario);
        }
    }
}