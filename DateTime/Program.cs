using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myDate = DateTime.Now;
            string formattedDate = "";

            //First Format: eg. 24-03-2020 18:01:00
            formattedDate = string.Format("{0:dd-MM-yyyy HH:mm:ss}",myDate);
            Console.WriteLine(formattedDate);

            //Second Format: eg. Tuesday of month March 2020
            formattedDate = string.Format("{0:dddd 'of month' MMMM 'year' yyyy}",myDate);
            Console.WriteLine(formattedDate);

            /* Third Format
             * Day Tuesday
             * Month March
             * Year 2020
             */
            formattedDate = string.Format("{0:'Day' dddd \n 'Month' MMMM \n 'Year' yyyy}", myDate);
            Console.WriteLine(formattedDate);

            //string formattedDate = string.Format("Date is {0:yyyy MMMM dddd}",myDate); // "{0}" = this is a placeholder 
            //Console.WriteLine(formattedDate);
        }
    }
}
