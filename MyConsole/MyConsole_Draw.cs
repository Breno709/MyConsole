using Console = Colorful.Console;
using System.Drawing;

namespace ExtConsole
{
    static public partial class MyConsole
    {
        #region Draw
        /// <summary>
        /// Realiza um desenho no console a partir do texto especificado
        /// </summary>
        /// <param name="asciiText">texto codificado em no padrão ASCII</param>
        /// <param name="font">Arte Figlet a ser utilizada</param>
        static public void DrawAsciiText(string asciiText, FgltFonts font)
        {
            Console.WriteAscii(asciiText, FigletFontSolver.SolveFont(font));
        }
        
        /// <summary>
        /// Desenha o texto indicado realizando uma interpolação linear entre as cores selecionadas
        /// </summary>
        /// <param name="text">Texto a ser escrito</param>
        /// <param name="start">Cor inicial do gradiente</param>
        /// <param name="end">Cor final do gradiente</param>
        static public void DrawGradient(string text, Color start, Color end)
        {
            Console.WriteWithGradient(text, start, end);
        }
        #endregion
    }
}
