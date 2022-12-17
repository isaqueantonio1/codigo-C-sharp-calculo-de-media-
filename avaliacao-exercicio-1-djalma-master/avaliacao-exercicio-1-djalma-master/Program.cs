using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avaliaçao_exerc1_djalma_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = -1, n2 = -1, tab = -1;


            Console.WriteLine("escreva seu nome:");
            string nome = Console.ReadLine();


            while (n1 < 0 || n1 > 10)
            {   
            
            Console.WriteLine("insira a nota 1");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("por favor, digite um numero valido de 0 a 10");

            }
           
            while (n2 < 0 || n2 > 10)

            {
             Console.WriteLine("insira a nota 2");
             n2 = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("por favor, digite um numero valido de 0 a 10");
            }

            while (tab < 0 || tab > 10)

            {
             Console.WriteLine("insira a nota de trabalho");
             tab = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("por favor, digite um numero valido de 0 a 10");
            }

            double media = (n1 + n2 + tab) / 3;
            media = Math.Round(media, 1);


            if (media >= 8.5 && media <= 10)

            {
                Console.ForegroundColor = ConsoleColor.Blue; 
                Console.WriteLine("\n " + nome + " sua média " +media+" é equivalente a A,Parabéns");
            }


            else if (media >= 7 && media <= 8.4)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n " + nome + " sua média " +media+" equivalente a B, Parabéns");
            }

            else if (media >= 6 && media <= 6.9)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine ("\n " + nome + " sua média "+media+ " é equivalente a C.Voce esta no caminho porém,Precisa se empenhar mais");
            }
            else if (media >= 0.1 && media <= 5.9)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n " + nome + "sua média " +media+ " e equivalente a D, precisa se empenhar mais");
            }

            else if (media == 0)
            {
              Console.ForegroundColor = ConsoleColor.Red;
              Console.WriteLine("\n " + nome + " sua media" +media+ "equivalente a E, precisa se empenhar mais");
            }
          
            Console.ReadKey();

        } 
    }
}
