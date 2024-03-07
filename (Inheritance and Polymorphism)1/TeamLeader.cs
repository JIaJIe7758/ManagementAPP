using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Inheritance_and_Polymorphism_1
{
    class TeamLeader : ProductionWorker
    {
        public double MonthlyBonus { get; set; }
        public int TrainingHours { get; set; }

        public TeamLeader(string name, int id, int shift, double pay, double monthlyBonus, int trainingHours)
            :base(name ,id ,shift ,pay)
        {
            MonthlyBonus = monthlyBonus;
            TrainingHours = trainingHours;
        }
        public override string ToString()
        {
            return base.ToString() + "Monthly Bonus: " + MonthlyBonus + "\r\n" +
                                    "Training Hours: " + TrainingHours + "\r\n";
        }
    }
}
