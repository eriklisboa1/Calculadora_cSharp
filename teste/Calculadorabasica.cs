using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
                Console.WriteLine("Digite a opção desejada:\n1-SOMA\n2-MULTIPLACAÇÃO\n3-SUBTRAÇÃO\n4-DIVISÃO\n");
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
                    case 3:
                        Console.WriteLine("Qual numero voce desejar usar para fazer a operação?");
                        int num2 = int.Parse(Console.ReadLine());
                        for(int i = 0; i < 10; i++)
                        {
                            int resul = num2 - i;
                            Console.WriteLine(num2 +"-"+i+"="+resul);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Qual numero voce desejar usa para fazer a operação?");
                        int num3 = int.Parse(Console.ReadLine());
                        for(int i = 1; i < 10; i++)
                        {
                            double resul = num3 / i;
                            Console.WriteLine(num3+"/"+i+"="+ (Math.Round(resul)));
                        }

                        break;
                    default:
                        Console.WriteLine("Digite um opção correta");
                        break;

                }
                Console.WriteLine("Digite 'o' para sair ou qualquer outra tecla para continuar");
                string opcao = Console.ReadLine();
                if (opcao == "o")//O MAISCULO PARA ENCERRAR O PROGRAMA
                {
                    running = false;
                }
            }

        }
    }
    
}
