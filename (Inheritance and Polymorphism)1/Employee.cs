using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Inheritance_and_Polymorphism_1
{
    abstract class Employee// abstract because we wont use Employee directly
    {
       


        public string EmployeeName { get; set; }
        public int EmployeeNumber { get; set; }


        public abstract int Shift { get; set; }
        public abstract double Pay { get; set; }

        public Employee(string name , int id, int shift)
        {
            EmployeeName = name;
            EmployeeNumber = id;
            Shift = shift;
        }
        public override string ToString()
        {
            return "Employee Name: " + EmployeeName + "\r\n" +
                    "Empoloyee ID: " + EmployeeNumber + "\r\n" +
                    "Worker Shift: " + Shift + "\r\n";


        }
    }
}
