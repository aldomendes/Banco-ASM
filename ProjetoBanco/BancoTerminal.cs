using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public class BancoTerminal()
    {
        BancoOperacoes bancoOperacoes = new BancoOperacoes();

        public void Start()
        {

            bool EmExecucao = true;

            while (EmExecucao)
            {
                Console.WriteLine("\nBem-vindo ao banco ASM, digite o número da opção desejada:\n");
                Console.WriteLine("1 - Checar o saldo");
                Console.WriteLine("2 - Depositar");
                Console.WriteLine("3 - Sacar");
                Console.WriteLine("4 - Sair\n");

                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("\nVocê escolheu checar o saldo:");
                        bancoOperacoes.ChecarSaldo();
                        break;

                    case 2:
                        Console.WriteLine("\nVocê escolheu depositar:");
                        bancoOperacoes.Depositar();
                        break;

                    case 3:
                        Console.WriteLine("\nVocê escolheu Sacar:");
                        bancoOperacoes.Retirar();
                        break;

                    case 4:
                        Console.WriteLine("\nVocê escolheu Sair:");
                        EmExecucao = false;
                        break;

                    default:
                        Console.WriteLine("\nOpção inválida, digite um número de 1 a 4");
                        break;

                }
            }
        }
    }
}

