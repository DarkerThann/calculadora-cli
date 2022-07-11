using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Menu
    {
        public Menu() { }

        public string MenuInput { get; set; }
        public double num1 { get; set; }
        public double num2 { get; set; }

        public void MenuOption()
        {
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("------------------------");
            Console.WriteLine("Somar");
            Console.WriteLine("Subtrair");
            Console.WriteLine("Dividir");
            Console.WriteLine("Multiplicar");
            Console.WriteLine("Sair");
            Console.WriteLine("------------------------");
            Console.Write("Digite uma opção: ");
        }

        public void UserOption()
        {
            Console.Write("Primeiro valor: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Segundo valor: ");
            num2 = Convert.ToDouble(Console.ReadLine());

        }
    }
}