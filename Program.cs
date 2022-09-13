using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date date= new Date();
            date.AssignValue();
            string data = date.DisplayValue();
            Console.WriteLine(data);
        }
    }
}
