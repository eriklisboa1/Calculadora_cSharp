using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                //IMPLEMENTEI UM MAIS COMPLEXO NO GITHUB ONDE EU ESTOU FAZENDO UMA DINMICA BEM LEGAL: EM ADAMENTO.
                //https://github.com/eriklisboa1


                Console.WriteLine("Bem vindo a calculadora escrita em  C#");
                Console.WriteLine("Digite 1 ou 2 para a seguinte operações:\n1-SOMA\n2-MULTIPLACAÇÃO");
                int op = int.Parse(Console.ReadLine());
                switch (op)

                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Qual numero voce deseja para fazer a operação?");
                        int num1 = int.Parse(Console.ReadLine());
                        int resul = Somar(num1);
                        Console.WriteLine(resul);
                        break;
                    case 2:
                        Console.Clear();    
                        Console.WriteLine("Qual numero voce deseja para fazer a operação?");
                        int num2 = int.Parse(Console.ReadLine());
                        int resul1 = Multiplicar(num2);
                        Console.WriteLine(resul1);
                        break;
                    default:
                        Console.WriteLine("Digite um opção correta");
                        break;

                }
                Console.WriteLine("Digite 'o' para sair ou qualquer outra tecla para continuar");
                string input = Console.ReadLine();
                if (input == "o")
                {
                    running = false;
                }


            }

        }

        static int Somar(int num1)
        {
            
            for (int i = 0; i < 10; i++)
            {
                int resul = i + num1;
                Console.WriteLine(i+"+"+num1+"="+resul);
                
            }
            return 0;
        }

        static int Multiplicar(int num2)
        {
            int resul1;
            for (int i = 0; i < 10; i++)
            {
                resul1 = i * num2;
                Console.WriteLine(i+"x"+num2+"="+resul1);
            }
            return 0;
        }
    }
    
}
