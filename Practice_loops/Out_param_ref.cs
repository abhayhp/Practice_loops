using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_loops
{
    public class Out_param_ref
    {

        public void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;

        }

        public void Calculation_(int c, int d, out int sum, out int sub, out int multiply)
        {
            sum = c + d;
            sub = c - d;
            multiply = c * d;

        }

        public void AcceptNames(params string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine(" ---- ");
        }

    }
}
