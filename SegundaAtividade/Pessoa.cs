namespace SegundaAtividade
{
    public class Pessoa
    {
        public string Nome { get; set; }
        private string Cpf { get;  set; }
        public int Idade { get; }
        private bool Vacinado { get; set; }

        public Pessoa(string nome, string cpf, int idade)
        {
            Nome = nome;
            Cpf = cpf;
            Idade = idade;
            Vacinado = false;
        }

        public override string ToString()
        {
            return "================================\r\n"
                   + "Nome: " + Nome + "\r\n"
                   + "Cpf: " + Cpf + "\r\n"
                   + "Vacinado: " + Vacinado + "\r\n"
                   + "================================";
        }

        public void Vacinar()
        {
            Vacinado = true;
        }
        
        public void AlterarCpf(string novoCpf)
        {
            Cpf = novoCpf;
        }
        
    }
}