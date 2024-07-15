using TerceiraAtividade.Entities;

namespace TerceiraAtividade
{
    class Program
    {
        static void Main(string[] args)
        {
            try
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
                    Console.Write("Nome: ");
                    string nomeCidadao = Console.ReadLine();
                    Console.Write("CPF: ");
                    string cpfCidadao = Console.ReadLine();
                    Console.Write("Idade: ");
                    int idadeCidadao = int.Parse(Console.ReadLine());
                    Cidadao cidadao = new Cidadao(nomeCidadao, cpfCidadao, idadeCidadao);
                    funcionario.Cadastrar(cidadao);

                    Console.Write("Vaciná-lo? [s/n]: ");
                    char vacinar = char.Parse(Console.ReadLine());

                    if (vacinar == 's' || vacinar == 'S')
                    {
                        cidadao.Vacinar();
                    }

                    Console.WriteLine();
                    Console.Write("Cadastrar outro paciente? [s/n]: ");
                    continuar = char.Parse(Console.ReadLine());

                } while (continuar == 's' || continuar == 'S');

                Console.WriteLine();
                Console.WriteLine(funcionario);
                Console.WriteLine();
                Console.WriteLine("Você deseja: ");
                Console.WriteLine("1 - Atualizar um CPF; ");
                Console.WriteLine("2 - Atualizar o numero de matricular;");
                Console.WriteLine("3 - Sair: ");
                int userResponse = int.Parse(Console.ReadLine());
                Admin adm = new Admin();
                switch (userResponse)
                {
                    case 1:
                        Console.Write("Informe o CPF atual: ");
                        string cpfAtual = Console.ReadLine();
                        Console.Write("Informe o novo CPF: ");
                        string novoCpf = Console.ReadLine();
                        Cidadao cidadao = funcionario.PegarCidadao(cpfAtual);
                        adm.AlterarCpf(cidadao, novoCpf);
                        Console.WriteLine("CPF Atualizado!");
                        break;
                    case 2:
                        Console.Write("Informe a matricula atual: ");
                        string matriculaAtual = Console.ReadLine();
                        Console.Write("Informe a nova matricula: ");
                        string novamatricula = Console.ReadLine();
                        adm.AlterarMatricula(funcionario, novamatricula);
                        Console.WriteLine("Matricula Atualizada!");
                        break;
                    default:
                        Console.WriteLine("Programa encerrado!");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}