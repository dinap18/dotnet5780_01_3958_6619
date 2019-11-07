//Eve Bibas 322276619 Dina Pinchuck337593958
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[20];
            int[] B = new int[20];
            int[] C = new int[20];
            int low = 22, high = 123;//minimum and maximum for random
            Random r = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < 20; i++)//enters numbers into arrays
            {
                A[i] = r.Next(low, high);
                B[i] = r.Next(low, high);
            }
            for (int i = 0; i < 20; i++)//enters numbers into C
            {
                if (A[i] >= B[i])
                    C[i] = A[i] - B[i];
                else
                    C[i] = B[i] - A[i];

            }
            for (int i = 0; i < 20; i++)//prints A
                Console.Write("{0 ,-3} ", A[i]);
            Console.WriteLine();
            for (int i = 0; i < 20; i++)//prints B
                Console.Write("{0 ,-3} ", B[i]);
            Console.WriteLine();
            for (int i = 0; i < 20; i++)//prints C
                Console.Write("{0 ,-3} ", C[i]);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
/*102 45  122 44  103 110 39  109 57  45  77  37  77  27  71  105 22  96  96  69
  32  92  94  88  95  106 84  92  96  87  83  42  38  48  119 115 92  49  60  63
  70  47  28  44  8   4   45  17  39  42  6   5   39  21  48  10  70  47  36  6
*/
    
