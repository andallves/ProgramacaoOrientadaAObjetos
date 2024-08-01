using System.Text;

namespace QuartaAtividade.Entities;

public class Funcionario : Pessoa
{
    public static int Identificador { get; private set; } = 0;
    private string _matricula;
    public string Cnpj { get; private set; }
    public List<Cidadao> Cadastrados { get; private set; } = new List<Cidadao>();
    public List<Agendamento> Agendamentos { get; private set; } = new List<Agendamento>();

    public Funcionario()
    {
        Identificador++;
    }

    public Funcionario(string nome, string cpf, int idade, string matricula, string cnpj) : base (nome, idade, cpf)
    {
        _matricula = matricula;
        Cnpj = cnpj;
        Identificador++;
    }

    public Funcionario(string nome, string cpf, int idade, string matricula, string cnpj, string endereco) : base (nome, idade, cpf, endereco)
    {
        _matricula = matricula;
        Cnpj = cnpj;
        Identificador++;
    }
    
    public Funcionario(string nome, string cpf, int idade, string matricula, string cnpj, string endereco,
        string telefone) : base (nome, idade, cpf, endereco, telefone)
    {
        _matricula = matricula;
        Cnpj = cnpj;
        Identificador++;
    }
    
    public Funcionario(string nome, string cpf, int idade, string matricula, string cnpj, string endereco, string telefone,
        string email) : base (nome, idade, cpf, endereco, telefone, email)
    {
        _matricula = matricula;
        Cnpj = cnpj;
        Identificador++;
    }

    public string Matricula
    {
        get { return _matricula; }
        set { _matricula = value; }
    }

    public void Cadastrar(Cidadao cidadao) {
        Cadastrados.Add(cidadao);
    }

    public Cidadao PegarCidadao(string cpf)
    {
        return Cadastrados.Find(x => x.Cpf == cpf);
    }

    public void RealizarAgendamento(Cidadao cidadao, DateTime dataDoAgendamento)
    {
        foreach (Agendamento agendamento in Agendamentos)
        {
            if (agendamento.Equals(new Agendamento(cidadao, dataDoAgendamento))) return;
        }
        Agendamentos.Add(new Agendamento(cidadao, dataDoAgendamento));
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("Funcionario: com Ideficador: ");
        sb.Append(Identificador);
        sb.Append(", ");
        sb.AppendLine(Nome);
        sb.Append("Matricular: ");
        sb.AppendLine(Matricula);
        sb.AppendLine("Pacientes cadastrados: ");
        foreach (Cidadao cidadao in Cadastrados)
        {
            sb.AppendLine(cidadao.ToString());
        }
        return sb.ToString();
    }

}