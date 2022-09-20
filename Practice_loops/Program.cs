using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //A objA = new A();
            //B objB = new B();
            //A objAB = new B(); 
            //objA.method_A();
            //objB.method_A();
            //objAB.method_A();


            //Properties_practice pp = new Properties_practice { Fish_count = 20, Pollution_level = "high"};
            //Console.WriteLine($"Fish_count :  { pp.Fish_count}\nPollution_level : {  pp.Pollution_level} ");
            //pp.func();





            //Meth_overriding mo = new Meth_overriding("Abhay", 40000, 1000);
            //mo.CalculateSalary();
            //Console.WriteLine(mo);

            //Manager mn = new Manager("ABhay D", 40000, 1000, 600);
            //mn.CalculateSalary();
            //Console.WriteLine(mn);
            //Console.WriteLine(mn.Print());



           // ----explicit interface----
            //IOrder order = new Transaction();
            //Console.WriteLine(order.DisplayDetails());

            //ICustomer customer = new Transaction();
            //Console.WriteLine(customer.DisplayDetails());

            //----refernce -----
            //int a = 10, b = 20;
            
            Out_param_ref r = new Out_param_ref();
            //r.Swap(ref a, ref b);
            //Console.WriteLine($" a: {a}, b : {b}");


            //// --- Out ---
            //int c = 20, d = 10, sum, sub, multiply;
            //r.Calculation_(c, d, out sum, out sub, out multiply);
            //Console.WriteLine($" sum: {sum} sub: {sub}  multiply: {multiply}");


            // --- params ----
            //r.AcceptNames("Abhay", "Suresh", "Akarsh");
            //r.AcceptNames("Anshul", "Arpit", "Suhas", "Shobha");
            //r.AcceptNames("Unnat", "Shanvi");


            string[] names = new string[5];
            Console.WriteLine("Enter five names ----");
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();
            }


            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($" names {i}: {names[i]}");
            }







            //Meth_overriding mn2 = new Manager("Abhay D", 40000, 1000, 600);
            //mn2.CalculateSalary();
            //Console.WriteLine(mn2);


            //for ( int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }

            //    Console.WriteLine();
            //}


            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 5; j >= 6 - i ; j--)
            //    {
            //        Console.Write(j);
            //    }

            //    Console.WriteLine();
            //}



            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 6 - i; j++)
            //    {
            //        Console.Write(Convert.ToChar('A' + (j - 1)));
            //    }

            //    Console.WriteLine();
            //}


            //for (int i = 1; i <= 5; i++)
            //{

            //    for ( int k = 1; k <= 6 - i; k++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(Convert.ToChar(('A' + (j - 1) )) + " ");
            //    }

            //    Console.WriteLine();
            //}

        }
    }
}
