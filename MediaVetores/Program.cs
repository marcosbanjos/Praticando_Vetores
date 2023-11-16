using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              Crie um programa que peça o nome e 4 notas de 10 alunos. 
              Ao final o programa deve mostrar a média de cada um dos alunos.
            */

            string[] nome = new string[2];
            decimal[] media = new decimal[2];
            decimal nota1 = 0;
            decimal nota2 = 0;
            decimal nota3 = 0;
            decimal nota4 = 0;

            for (int i = 0; i < nome.Length; i++) 
            {
                Console.Write("Insira o nome de um aluno: ");
                nome[i] = Console.ReadLine();
                
                Console.WriteLine("Insira a nota 1 deste aluno: ");
                nota1 = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Insira a nota 2 deste aluno: ");
                nota2 = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Insira a nota 3 deste aluno: ");
                nota3 = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Insira a nota 4 deste aluno: ");
                nota4 = Convert.ToDecimal(Console.ReadLine());

                media[i] = (nota1 + nota2 + nota3 + nota4) / 4;
            }

            for (int i = 0; i < nome.Length;i++)
            {
                Console.WriteLine($"A media do aluno {nome[i]} é {media[i]}");
            }
        }
    }
}
