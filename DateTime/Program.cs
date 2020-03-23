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
            Console.WriteLine(myDate.ToShortTimeString());
            Console.WriteLine(myDate.ToShortDateString());
            Console.WriteLine(myDate.ToLongDateString());
            Console.WriteLine(myDate.ToLongTimeString());
        }
    }
}
