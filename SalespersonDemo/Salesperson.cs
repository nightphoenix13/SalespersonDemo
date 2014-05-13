// Written by Zack Rosales
// Program from page 487-8, # 9

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalespersonDemo
{
    class Salesperson
    {
        // class attributes
        private string first;
        private string last;

        // constructor
        public Salesperson(string f, string l)
        {
            setClass(f, l);
        } // constructor end

        // properties
        public string First { set; get; } // first property end
        public string Last { set; get; } // last property end

        // class set method
        private void setClass(string f, string l)
        {
            First = f;
            Last = l;
        } // class set method end

        // toString override
        public override string ToString()
        {
            return First + " " + Last;
        } // end toString override
    } // Salesperson class end
}
