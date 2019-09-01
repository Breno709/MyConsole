using System;
using Colorful;
using Console = Colorful.Console;
using System.Drawing;
using System.Text;

namespace ExtConsole
{

    static public partial class MyConsole
    {

        #region Util
        /// <summary>
        /// Aguarda o usuário pressionar tecla Enter
        /// </summary>
        static public void WaitEnter()
        {
            Console.ReadLine();
        }

        /// <summary>
        /// Aguarda o usuário pressionar qualquer tecla.
        /// </summary>
        static public void WaitKey()
        {
            Console.ReadKey();
        }
        #endregion
    }
}
