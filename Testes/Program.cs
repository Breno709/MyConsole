using System;
using ExtConsole;
using Console = ExtConsole.MyConsole;
using System.Drawing;

namespace Testes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.DrawAsciiText("My Console", FgltFonts.standard);

            var resultado = Console.ReadLine<DateTime>("Insira uma data aqui (dd/mm/aaaa): ");
            Console.WriteLine($"Viu como foi facil obter o valor: {resultado}");

            //Console.DrawGradient("vai um grandiente aí?", Color.Chartreuse, Color.Fuchsia);

            Console.WaitEnter();
        }
    }
}
