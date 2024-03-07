using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Inheritance_and_Polymorphism_1
{
    public partial class frmEmployeeandWorkerClass : Form
    {
        

        


        public frmEmployeeandWorkerClass()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //we are not doing validation in this one
            string name = txtName.Text;
            int id = int.Parse(txtID.Text);
            int shift = int.Parse(txtShift.Text);
            double pay = double.Parse(txtPay.Text);
            double bonus = rbtnSupervisor.Checked || rbtnTeamLeader.Checked ? double.Parse(txtBonus.Text) : bonus = 0d;
            int trainingHours = rbtnTeamLeader.Checked ? int.Parse(txtTrainingHours.Text) : trainingHours = 0;
                            

            txtName.Text = "";
            txtID.Text = "";
            txtShift.Text = "";
            txtPay.Text = "";
            txtBonus.Text = "";
            txtTrainingHours.Text = "";


                          
                            
            




            if (rbtnWorker.Checked)
            {
                ProductionWorker worker = new ProductionWorker(name, id, shift, pay);

                txtOutput.Text = worker.ToString();
            }
            else if(rbtnSupervisor.Checked)
            {
                Supervisor supervisor = new Supervisor(name, id, shift, pay, bonus);
                txtOutput.Text = supervisor.ToString();
            }
            else
            {
                TeamLeader leader = new TeamLeader(name, id, shift, pay, bonus, trainingHours);
                txtOutput.Text = leader.ToString();
            }
            
        }

        private void rbtnWorker_CheckedChanged(object sender, EventArgs e)
        {
            txtBonus.Enabled = false;
            txtTrainingHours.Enabled = false;
        }

        private void rbtnSupervisor_CheckedChanged(object sender, EventArgs e)
        {
            txtBonus.Enabled = true;
            txtTrainingHours.Enabled = false;
        }

        private void rbtnTeamLeader_CheckedChanged(object sender, EventArgs e)
        {
            txtBonus.Enabled = true;
            txtTrainingHours.Enabled = true;
        }

        private void frmEmployeeandWorkerClass_Load(object sender, EventArgs e)
        {

        }
    }
}
