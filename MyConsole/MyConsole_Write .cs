using System;
using Colorful;
using Console = Colorful.Console;
using System.Drawing;
using System.Text;

namespace ExtConsole
{

    static public partial class MyConsole
    {
        #region Write
        /// <summary>
        /// Escreve no console a partir da posição atual o objeto especificado.
        /// </summary>
        /// <param name="message">Objeto a ser escrito na saída do console.</param>
        static public void Write<T>(T message)
        {
            //Aplicando um genérico no método, teoricamente é possível utilizar todas as sobrecargas
            //da função Console.Write() que contenha 1 parâmetro
            Console.Write(message);
        }

        /// <summary>
        /// Escreve no console a partir da posição atual o objeto especificado e, após, pula uma linha
        /// </summary>
        /// <param name="message">Objeto a ser escrito na saída do console.</param>
        static public void WriteLine<T>(T message)
        {
            Console.WriteLine(message);
        }

        /// <summary>
        /// Pula uma linha no console e, após, escreve no console.
        /// </summary>
        /// <param name="message">Objeto a ser escrito na saída do console.</param>
        static public void LineWrite<T>(T message)
        {
            Console.WriteLine();
            Console.Write(message);
        }

        /// <summary>
        /// Pula uma linha no console e, após, escreve no console e pula uma linha.
        /// </summary>
        /// <param name="message">Objeto a ser escrito na saída do console.</param>
        static public void LineWriteLine<T>(T message)
        {
            Console.WriteLine();
            Console.WriteLine(message);
        }

        /// <summary>
        /// Pula uma linha no console.
        /// </summary>
        static public void Line()
        {
            Console.WriteLine();
        }
        #endregion
    }
}
