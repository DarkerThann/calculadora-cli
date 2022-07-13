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

            string[] menu = { "O que você deseja Fazer?", "------------------------", "Somar", "Subtrair", "Dividir", "Multiplicar", "Sair", "------------------------", "Digite uma opção: " };
            foreach (string opcoes in menu)
            {
                Console.WriteLine(opcoes);
            }
        }

    }
}