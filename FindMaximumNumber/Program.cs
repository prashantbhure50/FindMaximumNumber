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
            int maxInteger= MaximumNumber.Maximum(1,2,3);
            Console.WriteLine(maxInteger);
            float maxFloat= MaximumNumber.Maximum(1.2f, 2.3f, 3.3f);
            Console.WriteLine(maxFloat);
            string maxString = MaximumNumber.Maximum("Apple","Peach","Banana");
            Console.WriteLine(maxString);
            Console.ReadKey();
            

        }
    }
}
