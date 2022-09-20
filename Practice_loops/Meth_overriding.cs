using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practice_loops
{
    public interface IPrintable
    {
        string Print();
    }
    public class Meth_overriding
    {
        protected int id;
        public string name;
        public double bs, hra, da, pf, pt, total, netpaid;

        public Meth_overriding(string name, double bs, double pt)
        {
            this.name = name;
            this.bs = bs;
            this.pt = pt;
        }

        public virtual void CalculateSalary()
        {
            hra = bs * 0.40;
            da = bs * 0.20;
            pf = bs * 0.12;
            total = bs + hra + da;
            netpaid = total - (pf + pt);
            Console.WriteLine("Base class");

        }

        public override string ToString()
        {
            return $"Employee name {name} , total salary {total} & Net paid {netpaid}";
        }


    }

    public class Manager : Meth_overriding, IPrintable
    {
        private double ta;

        public Manager(string name, double bs, double pt, double ta) : base(name, bs, pt)
        {
            this.ta = ta;
        }

        public new void CalculateSalary()
        {
            hra = bs * 0.40;
            da = bs * 0.20;
            pf = bs * 0.12;
            total = bs + hra + da + ta;
            netpaid = total - (pf + pt);
            Console.WriteLine("Manager class");

        }

        public string Print()
        {
            return $"Manager name {name} , total_salary {total} & Net paid {netpaid}"; 
        }

        public override string ToString()
        {
            return $"Manager name {name} , total salary {total} & Net paid {netpaid}";
        }

    }





    
}
