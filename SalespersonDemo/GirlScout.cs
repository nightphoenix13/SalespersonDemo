// Written by Zack Rosales
// Program from page 487-8, # 9

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalespersonDemo
{
    class GirlScout : Salesperson, ISellable
    {
        // sub-class attributes
        private int boxesSold;

        // constructor
        public GirlScout(string f, string l)
            : base(f, l)
        {
            BoxesSold = 0;
        } // constructor end

        // properties
        public int BoxesSold
        {
            get
            {
                return boxesSold;
            } // end get
            set
            {
                if (value >= 0)
                {
                    boxesSold = value;
                } // end if
                else
                {
                    boxesSold = 0;
                } // end else
            } // end set
        } // BoxesSold property end

        // ISellable methods from interface
        public string SalesSpeech() // SalesSpeech method start
        {
            return "With this many varieties, you'll find something you love.";
        } // SalesSpeech method end
        public void MakeSale(int val) // MakeSale method start
        {
            if (val > 0)
            {
                boxesSold += val;
            } // end if
        } // MakeSale method end
    } // GirlScout class end
}