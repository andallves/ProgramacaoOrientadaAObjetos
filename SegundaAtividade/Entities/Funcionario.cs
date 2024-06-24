using System.Collections.Generic;
using System.Text;

namespace SegundaAtividade
{
    public class Funcionario : Pessoa
    {
        public static int Identificador { get; private set; } = 0;
        private string _matricula;
        public string Cnpj { get; private set; }
        public List<Pessoa> Cadastrados { get; private set; } = new List<Pessoa>();

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

        public string Matricula
        {
            get { return _matricula; }
            set { _matricula = value; }
        }

        public void Cadastrar(Pessoa cidadao) {
            Cadastrados.Add(cidadao);
        }

        public Pessoa PegarCidadao(string cpf)
        {
            return Cadastrados.Find(x => x.Cpf == cpf);
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
            foreach (Pessoa pessoa in Cadastrados)
            {
                sb.AppendLine(pessoa.ToString());
            }
            return sb.ToString();
        }
    }
}