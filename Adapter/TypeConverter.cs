using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Adapter
{
    internal class TypeConverter
    {
        public ReturningStrings ReturningStrings { get; set; }
        public PrintingInts PrintingInts { get; set; }

        public TypeConverter()
        {
            ReturningStrings = new ReturningStrings();
            PrintingInts = new PrintingInts();
        }

        public void Run()
        {
            var number = Convert.ToInt32(ReturningStrings.ReturnString());

            PrintingInts.Print(number);
        }
    }
}