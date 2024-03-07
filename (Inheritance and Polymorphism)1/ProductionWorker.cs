using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Inheritance_and_Polymorphism_1
{
    class ProductionWorker : Employee
    {


        


        public int ShiftNumber { get; set; }
        public double HourlyPay { get; set; }

        public override double Pay
        {
            get
            {
                return HourlyPay;
            }
            set
            {
                HourlyPay = value;
            }
        }

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
       

        public ProductionWorker(string name , int id , int shift , double hourlyPay) :base (name , id ,shift)
        {

            ShiftNumber = shift;
            HourlyPay = hourlyPay;
        }

        public override string ToString()
        {
            return base.ToString()  //return the name  id and shift from base class + pay in this class
                            + "Worker Hourly Pay: " + HourlyPay + "\r\n";
        }
    }
}
