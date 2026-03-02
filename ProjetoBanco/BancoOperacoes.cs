using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public class BancoOperacoes
    {
        float saldo;

        public void ChecarSaldo()
        {
            Console.WriteLine($"O saldo atual é de R$ {saldo}");
        }

        public void Depositar()
        {
            Console.WriteLine($"Digite o valor a ser depositado:");

            if (float.TryParse(Console.ReadLine(), out float valor) && valor > 0)
            {
                saldo += valor;
                Console.WriteLine($"Valor depositado!");
            }

            else
            {
                Console.WriteLine("O valor deve ser superior a R$ 0");
            }
        }

        public void Retirar()
        {
            Console.WriteLine($"Digite o valor a ser sacado");
            if (float.TryParse(Console.ReadLine(), out float valor) && valor > 0 && valor <= saldo)
            {
                    saldo -= valor;
                    Console.WriteLine($"Valor sacado!");                
            }

            else
            {
                Console.WriteLine("O valor digitado é inválido ou é maior do que tem disponível na conta");
            }
        }
    }
}
