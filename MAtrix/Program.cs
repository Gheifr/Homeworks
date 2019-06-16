
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3L2
{
    class Program
    {
        static void Main(string[] args)
        {

            var testMatrix = new Matrix<String>(3, 2);

            testMatrix.Insert(1,1, "Someshit");
            Console.WriteLine(testMatrix.GetCount());
            Console.ReadKey();

            foreach (var item in testMatrix)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
