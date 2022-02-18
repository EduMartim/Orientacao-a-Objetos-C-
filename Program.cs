using System;
using Jogo_de_RPG_usando_OO.src.Entities;

namespace Jogo_de_RPG_usando_OO
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");

            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(7));


        }
    }
}
