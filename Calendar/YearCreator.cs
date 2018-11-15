using System;
namespace Calendar
{
/// <summary>
/// Statische Klasse die uns ein Jahr erzeugt
/// </summary>
    static class YearCreator
    {
        /// <summary>
        /// Methode für leeres Jahr
        /// </summary>
        /// <returns>Ein Jahr</returns>
        public static Year createYear()
        {
            DateTime date = DateTime.Now;
            Year year = new Year(date.Year);
            return year;
        }
        /// <summary>
        /// Methode für ein Jahr mit Jahresangabe
        /// </summary>
        /// <param name="yearnumber"></param>
        /// <returns>Ein Jahr</returns>
        public static Year createYear(int yearnumber)
        {
            if (yearnumber >= 0)
            {
                Year year = new Year(yearnumber);
                return year;
           }
            else
            {
                Console.WriteLine("Wähle aktuelles Jahr");
                return createYear();
            }
        }
    }
}
