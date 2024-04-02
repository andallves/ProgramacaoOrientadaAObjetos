using System;

namespace SegundaAtividade
{
    public class Admin 
    { 
        private string Senha { get; }

        public Admin(string senha)
        {
            Senha = senha;
        }

        private void AlterarCpf(Pessoa pessoa, string novoCpf)
        {
            bool senhaEstaCorreta = VerificarSenhaAdmin();
            if (senhaEstaCorreta)
            {
                pessoa.AlterarCpf(novoCpf);
            }
        }

        private bool VerificarSenhaAdmin()
        {
            Console.Write("Informe a senha de Admin: ");
            string senha = Console.ReadLine();
            if (senha == Senha)
            {
                return true;
            }
            return false;
        }
    }
}