using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_loops
{
    public interface IOrder
    {
        string DisplayDetails();
    }

    public interface ICustomer
    {
        string DisplayDetails();
    }
    public class Transaction : IOrder, ICustomer
    {
        string IOrder.DisplayDetails()
        {
            return $"IOrder details";
        }

        string ICustomer.DisplayDetails()
        {
            return $"CUstomer details";
        }
    }
}
