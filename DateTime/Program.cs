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
            string formattedDate = string.Format("Date is {0:yyyy MMMM dddd}",myDate); // "{0}" = this is a placeholder 
            Console.WriteLine(formattedDate);
        }
    }
}
