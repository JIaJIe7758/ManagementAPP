using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Inheritance_and_Polymorphism_1
{
    class Supervisor : Employee
    {
        public double AnnualPay;
        public double AnnualBonus;
        public int ShiftNumber;


        public override int Shift
        {
            get
            {
                return ShiftNumber;
            }
            set
            {
                ShiftNumber = value;
            }
        }

        public override double Pay
        {
            get
            {
                return AnnualPay;
            }
            set
            {
                AnnualPay = value;
            }
        }

        public Supervisor(string name , int id, int shift , double annualPay, double annualBonus) :base (name , id , shift)
        {
            AnnualPay= annualPay;
            AnnualBonus= annualBonus;
        }
        public override string ToString()
        {
            return base.ToString() + "Annual Salary: " + AnnualPay + "\r\n" +
                                    "Annual Bonus: " + AnnualBonus + "\r\n";
        }
    }
}
