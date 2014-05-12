// Written by Zack Rosales
// Program from page 487-8, # 9

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalespersonDemo
{
    class RealEstateSalesperson : Salesperson, ISellable
    {
        // sub-class attributes
        private int totalSold;
        private int commissionEarned;
        private double commissionRate;

        // constructor
        public RealEstateSalesperson(string f, string l, double cr)
            : base(f, l)
        {
            setClass(cr);
        } // contructor end

        // properties
        public int TotalSold
        {
            get
            {
                return totalSold;
            } // end get
            set
            {
                if (value >= 0)
                {
                    totalSold = value;
                } // end if
                else
                {
                    totalSold = 0;
                } // end else
            } // end set
        } // TotalSold property end
        public int CommissionEarned
        {
            get
            {
                return commissionEarned;
            } // end get
            set
            {
                if (value >= 0)
                {
                    commissionEarned = value;
                } // end if
                else
                {
                    commissionEarned = 0;
                } // end else
            } // end set
        } // CommissionEarned property end
        public double CommissionRate
        {
            get
            {
                return commissionRate;
            } // end get
            set
            {
                if (value >= 0.0)
                {
                    commissionRate = value;
                } // end if
                else
                {
                    commissionRate = 0.0;
                } // end else
            } // end set
        } // CommissionRate property end

        // class set method
        private void setClass(double cr)
        {
            CommissionRate = cr;
            TotalSold = 0;
            CommissionEarned = 0;
        } // end class set method

        // ISellable methods from interface
        public string SalesSpeech() // SalesSpeech method start
        {
            return "I will do everything I can to get you your dream home.";
        } // SalesSpeech method end
        public void MakeSale(int val) // MakeSale method start
        {
            if (val > 0)
            {
                TotalSold += val;
                calculateCommission(val);
            } // end if
        } // MakeSale method end

        // calculateCommission method sets the commission
        private void calculateCommission(int val)
        {
            CommissionEarned += (int)(val * (CommissionRate / 100));
        } // calculateCommission method end
    } // RealEstateSalesperson class end
}
