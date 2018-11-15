using System;


namespace Calendar
{
    /// <summary>
    /// Statische Klasse für die Eingabe der Commandozeileneingabe
    /// </summary>
    static class CommandLineParser
    {
        /// <summary>
        /// Convertiert das erste Argument der Commandozeile in Int32
        /// </summary>
        /// <param name="args">Commandozeilenarray</param>
        /// <returns>int Jahreszahl wenn gültig sonst -1 </returns>
        public static int parseArguments(string[] args)
        {
            try
            {
                return Convert.ToInt32(args[0]);
            }
            catch (Exception ex) when (ex is FormatException || ex is IndexOutOfRangeException)
            {
                return -1;
            }     
        }
    }
}
