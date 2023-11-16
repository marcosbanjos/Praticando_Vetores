using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Crie um programa que peça o nome e a idade de 10 pessoas.
             Ao final o programa deve mostrar uma lista que indica se são maiores ou menores de idade.
            */

            string[] nomes = new string[2];
            int[] idades = new int[2];

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write("Insira o nome de um aluno: ");
                nomes[i] = Console.ReadLine();

                Console.Write("Insira a idade do aluno: ");
                idades[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            for (int i = 0;i < nomes.Length;i++)
            {
                if (idades[i] < 18)
                {
                    Console.WriteLine($"O aluno {nomes[i]} é de menor");
                }
                else
                {
                    Console.WriteLine($"O aluno {nomes[i]} é de maior");
                }
                
            }

        }
    }
}
