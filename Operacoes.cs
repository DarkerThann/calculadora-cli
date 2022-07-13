using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Operacoes : Menu
    {

        public Operacoes() { }


        public void UserChoise()
        {
            MenuInput = Console.ReadLine();

            switch (MenuInput.ToUpper())
            {
                case "SOMAR":
                    UserValues();
                    Console.Clear();
                    Console.WriteLine($"{num1} + {num2} = {Somar(num1, num2)}");
                    MenuOption();
                    UserChoise();
                    break;
                case "SUBTRAIR":
                    UserValues();
                    Console.Clear();
                    Console.WriteLine($"{num1} - {num2} = {Subtrair(num1, num2)}");
                    MenuOption();
                    UserChoise();
                    break;
                case "DIVIDIR":
                    UserValues();
                    Console.Clear();
                    Console.WriteLine($"{num1} ÷ {num2} = {Dividir(num1, num2)}");
                    MenuOption();
                    UserChoise();
                    break;
                case "MULTIPLICAR":
                    UserValues();
                    Console.Clear();
                    Console.WriteLine($"{num1} X {num2} = {Multiplicar(num1, num2)}");
                    MenuOption();
                    UserChoise();
                    break;
                case "SAIR": Environment.Exit(0); 
                    break; 
                default:
                    Console.Clear();
                    Console.WriteLine("A opção escolhida não existe. Por favor digite novamente. ");
                    MenuOption();
                    UserChoise();
                    break;
            }
        }

        public void UserValues()
        {
            Console.Write("Primeiro valor: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Segundo valor: ");
            num2 = Convert.ToDouble(Console.ReadLine());

        }

        public double Somar(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Subtrair(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Dividir(double num1, double num2)
        {
            return num1 / num2;  
        }

        public double Multiplicar(double num1, double num2)
        {
            return num1 * num2;
        }


    }
}
