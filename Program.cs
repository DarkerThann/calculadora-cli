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
            Menu menu = new Menu();
            Operacoes operacoes = new Operacoes();

            menu.MenuOption();
            operacoes.UserChoise();
        }
    }
}
