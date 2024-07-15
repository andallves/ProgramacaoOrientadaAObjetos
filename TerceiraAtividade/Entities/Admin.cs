namespace TerceiraAtividade.Entities;

public class Admin
{
    private string _senha;

    public Admin()
    {
        _senha = "Admin123";
    }

    public void AlterarCpf(Cidadao cidadao, string novoCpf)
    {
        if (ESenhaCorreta())
        {
            cidadao.Cpf = novoCpf;
        }
    }

    public void AlterarMatricula(Funcionario funcionario, string novaMatricula)
    {
        if (ESenhaCorreta())
        {
            funcionario.Matricula = novaMatricula;
        }
    }

    public bool ESenhaCorreta()
    {
        string senha = "";
        for (int i = 1; i <= 3; i++) {
            Console.Write("Informe a sua senha: ");
            senha = Console.ReadLine();
            if (senha == _senha) return true;
        }
        Console.WriteLine("Senha errada! Operação cancelada");
        return _senha == senha;
    }
}