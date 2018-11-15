using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class Year
    {
        private DateTime date;
        public int yearnumber;
        private int startday;
        private List<Month> monthqueue = new List<Month>();
        public Year(int yearnumber)
        {
            this.yearnumber = yearnumber;
            date = new DateTime(yearnumber,1,1);
            startday = (int)date.DayOfWeek;
            fillYear();

            Console.WriteLine(date);
            Console.WriteLine(startday);
            foreach (var date in monthqueue)
            {
                Console.WriteLine(date);
            }
        }
        private void fillYear()
        {
            for (int i = 0; i < 11; i++)
            {
                monthqueue.Add(new Month(new DateTime(yearnumber,i+1, 1)));
            }
        }
    }
}
