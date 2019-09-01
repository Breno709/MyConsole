using System;
using Console = Colorful.Console;

namespace ExtConsole
{
    static public partial class MyConsole
    {
        #region Read
        /// <summary>
        /// Lê a linha inserida
        /// </summary>
        static public string ReadLine()
        {
            return Console.ReadLine();
        }

        /// <summary>
        /// Lê a linha inserida após escrever uma mensagem
        /// </summary>
        /// <param name="message">Mensagem a ser exibida no console</param>
        static public string ReadLine(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
        
        /// <summary>
        /// Lê a linha inserida após escrever uma mensagem e converte o dado para o tipo <see cref="T"/> especificado
        /// </summary>
        /// <typeparam name="T">Uma <see cref="struct"/> que contenha o método Parse</typeparam>
        /// <param name="message">Mensagem a ser exibida ao usuário</param>
        /// <returns>Retorna o dado inserido pelo usuário convertido em <typeparamref name="T"/></returns>
        static public T ReadLine<T>(string message) where T: struct
        {
            var expectedResult = typeof(T);
            Console.Write(message);
            var valueRead = Console.ReadLine();
            var method = expectedResult.GetMethod("Parse", new Type[] { typeof(string) });
            if (method != null)
            {
                return (T)method.Invoke(null, new object[] { valueRead });
            }
            else return default;
        }
        #endregion
    }
}
