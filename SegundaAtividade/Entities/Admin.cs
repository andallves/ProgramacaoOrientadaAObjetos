﻿using System;

namespace SegundaAtividade
{
    public class Admin
    {
        private readonly string _senha;

        public Admin()
        {
            _senha = "Admin123";
        }

        public void AlterarCpf(Pessoa pessoa, string novoCpf)
        {
            if (ESenhaCorreta())
            {
                pessoa.Cpf = novoCpf;
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
}