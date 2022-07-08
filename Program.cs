using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("------------------------");
            Console.WriteLine("Somar");
            Console.WriteLine("Subtrair");
            Console.WriteLine("Dividir");
            Console.WriteLine("Multiplicar");
            Console.WriteLine("------------------------");
            Console.Write("Digite uma opção: ");

            string menuOption = Console.ReadLine();
            switch (menuOption.ToUpper())
            {
                case "SOMAR":
                        Somar(); 
                        break;
                case "SUBTRAIR":
                        Subtrair();
                        break;
                case "DIVIDIR":
                        Dividir();
                        break;
                case "MULTIPLICAR":
                        Multiplicar();
                        break;
                default:
                    Console.Clear();
                    Console.WriteLine("A opção escolhida não existe. Por favor escolha novamente. ");                    
                    Menu();
                    break;
            }
        }

        static void Somar()
        {
            Console.Write("Primeiro valor: ");
            decimal num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Segundo valor: ");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());

            Console.Clear();
            //Espaco();
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            Console.WriteLine("------------------------");
            Menu();
        }

        static void Subtrair()
        {
            Console.Write("Primeiro valor: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Segundo valor: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Espaco();
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            Espaco();
            Menu();
        }

        static void Dividir()
        {
            Console.Write("Primeiro valor: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Segundo valor: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Espaco();
            Console.WriteLine($"{num1} ÷ {num2} = {num1 / num2}");
            Espaco();
            Menu();
        }

        static void Multiplicar()
        {
            Console.Write("Primeiro valor: ");
            decimal num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Segundo valor: ");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());

            Console.Clear();
            Espaco();
            Console.WriteLine($"{num1} x {num2} = {num1 * num2}");
            Espaco();
            Menu();
        }

        static void Espaco()
        {
            Console.WriteLine();
        }
    }
}
