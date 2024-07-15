using System.Text;

namespace TerceiraAtividade.Entities;

public class Funcionario : Cidadao
{
        public static int Identificador { get; private set; } = 0;
        private string _matricula;
        public string Cnpj { get; private set; }
        public List<Cidadao> Cadastrados { get; private set; } = new List<Cidadao>();
        public List<DateTime> Agendamentos { get; private set; } = new List<DateTime>();

        public Funcionario()
        {
            Identificador++;
        }

        public Funcionario(string nome, string cpf, int idade, string matricula, string cnpj) : base (nome, cpf, idade)
        {
            _matricula = matricula;
            Cnpj = cnpj;
            Identificador++;
        }

        public Funcionario(string nome, string cpf, int idade, string matricula, string cnpj, string telefone,
            string email) :
            base (nome,
            cpf,
            idade, telefone, email)
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

        public void RealizarAgendamento(DateTime date)
        {
            if (Agendamentos.Contains(date)) return;
            Agendamentos.Add(date);
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