using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2_Avaliaçao_Djalma_S_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                
                    string cidades = null;
                    int cidade;
                    Console.WriteLine("De 1 a 7, digite a cidade que deseja: ");
                    Console.Write(" 1–Atibaia\n 2–Bragança Paulista\n 3–Mairiporã\n");

                    Console.Write(" 4–Nazaré\n 5–Terra Preta\n 6–Extrema\n 7–Vargem\n");

                    cidade = int.Parse(Console.ReadLine());

                    Console.ForegroundColor = ConsoleColor.Blue;
                    switch (cidade)
                    {
                        case 1:
                            cidades = "Atibaia";
                            break;
                        case 2:
                            cidades = "Bragança Paulista";
                            break;
                        case 3:
                            cidades = "Mairiporã";
                            break;
                        case 4:
                            cidades = "Nazaré";
                            break;
                        case 5:
                            cidades = "Terra Preta";
                            break;
                        case 6:
                            cidades = "Extrema";
                            break;
                        case 7:
                            cidades = "Vargem";
                            break;

                    }

                    string Mees = null;
                    int dia, mes, ano;

                    Console.WriteLine("Digite a data (dd/mm/aaaa),OBS: com o / ");

                    var DataAtual = Convert.ToDateTime(Console.ReadLine());

                    mes = DataAtual.Month;
                    dia = DataAtual.Day;
                    ano = DataAtual.Year;


                    Console.ForegroundColor = ConsoleColor.Red;

                    switch (mes)
                    {


                        case 1:
                            Mees = "Janeiro";
                            break;
                        case 2:
                            Mees = "Fevereiro";
                            break;
                        case 3:
                            Mees = "Março";
                            break;
                        case 4:
                            Mees = "Abril";
                            break;
                        case 5:
                            Mees = "Maio";
                            break;
                        case 6:
                            Mees = "Junho";
                            break;
                        case 7:
                            Mees = "Julho";
                            break;
                        case 8:
                            Mees = "Agosto";
                            break;
                        case 9:
                            Mees = "Setembro";
                            break;
                        case 10:
                            Mees = "Outubro";
                            break;
                        case 11:
                            Mees = "Novembro";
                            break;
                        case 12:
                            Mees = "Dezembro";
                            break;

                    }
                    Console.WriteLine(cidades + ", " + dia + " de " + Mees + " de " + ano + ".");
                    Console.ReadKey();
                }
            }
    }
}
