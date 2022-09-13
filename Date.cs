using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    public class Date
    {
        int day, year;
        string month;

        public void AssignValue()
        {
            day = 13;
            month = "sept";
            year = 2022;
        }
        public string DisplayValue()
        {
            return $"Date is :{day}/{month}/{year}";
        }
    }
}
