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
                    UserOption();
                    Console.Clear();
                    Console.WriteLine($"{num1} + {num2} = {Somar(num1, num2)}");
                    MenuOption();
                    UserChoise();
                    break;
                case "SUBTRAIR":
                    UserOption();
                    Console.Clear();
                    Console.WriteLine($"{num1} - {num2} = {Subtrair(num1, num2)}");
                    MenuOption();
                    UserChoise();
                    break;
                case "DIVIDIR":
                    UserOption();
                    Console.Clear();
                    Console.WriteLine($"{num1} ÷ {num2} = {Dividir(num1, num2)}");
                    MenuOption();
                    UserChoise();
                    break;
                case "MULTIPLICAR":
                    UserOption();
                    Console.Clear();
                    Multiplicar(num1, num2);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("A opção escolhida não existe. Por favor digite novamente. ");
                    MenuOption();
                    UserChoise();
                    break;
            }
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
