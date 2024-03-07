namespace _Inheritance_and_Polymorphism_1
{
    partial class frmEmployeeandWorkerClass
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtShift = new System.Windows.Forms.TextBox();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnSupervisor = new System.Windows.Forms.RadioButton();
            this.rbtnWorker = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.rbtnTeamLeader = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTrainingHours = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Shift Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pay";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(195, 107);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 4;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(195, 145);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 5;
            // 
            // txtShift
            // 
            this.txtShift.Location = new System.Drawing.Point(195, 186);
            this.txtShift.Name = "txtShift";
            this.txtShift.Size = new System.Drawing.Size(100, 22);
            this.txtShift.TabIndex = 6;
            // 
            // txtPay
            // 
            this.txtPay.Location = new System.Drawing.Point(195, 225);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(100, 22);
            this.txtPay.TabIndex = 7;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(207, 341);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(88, 29);
            this.btnDisplay.TabIndex = 8;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(65, 376);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(280, 115);
            this.txtOutput.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnTeamLeader);
            this.groupBox1.Controls.Add(this.rbtnSupervisor);
            this.groupBox1.Controls.Add(this.rbtnWorker);
            this.groupBox1.Location = new System.Drawing.Point(65, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 97);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Position";
            // 
            // rbtnSupervisor
            // 
            this.rbtnSupervisor.AutoSize = true;
            this.rbtnSupervisor.Location = new System.Drawing.Point(35, 45);
            this.rbtnSupervisor.Name = "rbtnSupervisor";
            this.rbtnSupervisor.Size = new System.Drawing.Size(93, 20);
            this.rbtnSupervisor.TabIndex = 1;
            this.rbtnSupervisor.TabStop = true;
            this.rbtnSupervisor.Text = "Supervisor";
            this.rbtnSupervisor.UseVisualStyleBackColor = true;
            this.rbtnSupervisor.CheckedChanged += new System.EventHandler(this.rbtnSupervisor_CheckedChanged);
            // 
            // rbtnWorker
            // 
            this.rbtnWorker.AutoSize = true;
            this.rbtnWorker.Location = new System.Drawing.Point(35, 22);
            this.rbtnWorker.Name = "rbtnWorker";
            this.rbtnWorker.Size = new System.Drawing.Size(72, 20);
            this.rbtnWorker.TabIndex = 0;
            this.rbtnWorker.TabStop = true;
            this.rbtnWorker.Text = "Worker";
            this.rbtnWorker.UseVisualStyleBackColor = true;
            this.rbtnWorker.CheckedChanged += new System.EventHandler(this.rbtnWorker_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Bonus";
            // 
            // txtBonus
            // 
            this.txtBonus.Location = new System.Drawing.Point(195, 271);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(100, 22);
            this.txtBonus.TabIndex = 3;
            // 
            // rbtnTeamLeader
            // 
            this.rbtnTeamLeader.AutoSize = true;
            this.rbtnTeamLeader.Location = new System.Drawing.Point(35, 71);
            this.rbtnTeamLeader.Name = "rbtnTeamLeader";
            this.rbtnTeamLeader.Size = new System.Drawing.Size(110, 20);
            this.rbtnTeamLeader.TabIndex = 2;
            this.rbtnTeamLeader.TabStop = true;
            this.rbtnTeamLeader.Text = "Team Leader";
            this.rbtnTeamLeader.UseVisualStyleBackColor = true;
            this.rbtnTeamLeader.CheckedChanged += new System.EventHandler(this.rbtnTeamLeader_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Training Hours";
            // 
            // txtTrainingHours
            // 
            this.txtTrainingHours.Location = new System.Drawing.Point(195, 313);
            this.txtTrainingHours.Name = "txtTrainingHours";
            this.txtTrainingHours.Size = new System.Drawing.Size(100, 22);
            this.txtTrainingHours.TabIndex = 12;
            // 
            // frmEmployeeandWorkerClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 520);
            this.Controls.Add(this.txtTrainingHours);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBonus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txtPay);
            this.Controls.Add(this.txtShift);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEmployeeandWorkerClass";
            this.Text = "Employee and Worker";
            this.Load += new System.EventHandler(this.frmEmployeeandWorkerClass_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtShift;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnSupervisor;
        private System.Windows.Forms.RadioButton rbtnWorker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBonus;
        private System.Windows.Forms.RadioButton rbtnTeamLeader;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTrainingHours;
    }
}

