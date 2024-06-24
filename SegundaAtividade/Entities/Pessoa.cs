namespace SegundaAtividade
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; private set; }
        private string _cpf;
        private bool _vacinado = false;

        public Pessoa() { }

        public Pessoa(string nome, string cpf, int idade)
        {
            Nome = nome;
            _cpf = cpf;
            Idade = idade;
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
}