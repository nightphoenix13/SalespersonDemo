using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalespersonDemo
{
    interface ISellable
    {
        // methods to be defined by class that uses interface
        string SalesSpeech();
        void MakeSale(int val);
    } // ISellable interface end
}
