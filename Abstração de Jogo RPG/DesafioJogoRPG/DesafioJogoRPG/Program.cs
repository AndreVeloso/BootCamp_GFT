using DesafioJogoRPG.Entities;
using System;

namespace DesafioJogoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight("Arus", 23, "Knigth");
            
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");

            Console.WriteLine(knight);
            Console.WriteLine(wizard);
        }
    }
}
