using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumber
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to Maximum Number Problem");
            MaximumNumber<int> maxInteger = new MaximumNumber<int>(4,2,3);
            Console.WriteLine("MaxInteger - "+maxInteger.maxMethod());
            MaximumNumber<float> maxFloat = new MaximumNumber<float>(4.3f, 2.3f, 3.3f);
            Console.WriteLine( "MaxFloat - "+maxFloat.maxMethod());
            MaximumNumber<double> maxDouble = new MaximumNumber<double>(4.3, 2.3, 5.3);
            Console.WriteLine( "MaxString - "+maxDouble.maxMethod());
           Console.ReadKey();
            

        }

       
    }
}
