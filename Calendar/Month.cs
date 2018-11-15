using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class Month
    {
        DateTime date;
        int startday;
        int length;
        public Month(DateTime date)
        {
            this.date = date;
            startday = (int)date.DayOfWeek;
            length = date.
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append();
            for (int i = 0; i < length; i++)
            {

            }                
            return sb;
        }
    }
}
