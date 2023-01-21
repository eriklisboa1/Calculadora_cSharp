using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Bem vindo a calculadora escrita em  C#");
                Console.WriteLine("Digite 1 ou 2 para a seguinte operações:\n1-SOMA\n2-MULTIPLACAÇÃO");
                int op = int.Parse(Console.ReadLine());
                switch (op)

                {
                    case 1:
                        Console.WriteLine("Qual numero voce deseja para fazer a operação?");
                        int num = int.Parse(Console.ReadLine());
                        for (int i = 0; i < 10; i++)
                        {
                            int resul = i + num;
                            Console.WriteLine(num + "+" + i + "=" + resul);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Qual numero voce deseja para fazer a operação?");
                        int num1 = int.Parse(Console.ReadLine());
                        for (int i = 0; i < 10; i++)
                        {
                            int resul = num1 * i;
                            Console.WriteLine(num1 + "*" + i + "=" + resul);
                        }
                        break;
                    default:
                        Console.WriteLine("Digite um opção correta");
                        break;

                }
                Console.WriteLine("Digite 'O' para sair ou qualquer outra tecla para continuar");
                string input = Console.ReadLine();
                if (input == "O")
                {
                    running = false;
                }
            }

        }
    }
    
}
