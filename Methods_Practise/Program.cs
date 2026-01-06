using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Practise
{
    internal class Program
    {
        public String SampleMethod()
        {
            return "This is a sample method.";
        }
        public static String StaticSampleMethod()
        {
            return "This is Static sample method.";
        }

        static void Main(String[] args)
        {
            Program s = new Program();
            Console.WriteLine(s.SampleMethod());
            Console.WriteLine(StaticSampleMethod());
        }
    }
}

//CODE TESTED SUCCESSFULLY IN .NET FIDDLE ONLINE IDE