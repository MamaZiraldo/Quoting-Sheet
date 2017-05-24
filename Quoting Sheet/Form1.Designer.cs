namespace Quoting_Sheet
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DesignTime = new System.Windows.Forms.NumericUpDown();
            this.Calculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MachineTime = new System.Windows.Forms.NumericUpDown();
            this.ManualLabourTime = new System.Windows.Forms.NumericUpDown();
            this.MaterialCost = new System.Windows.Forms.NumericUpDown();
            this.Quantity = new System.Windows.Forms.NumericUpDown();
            this.RushJob = new System.Windows.Forms.CheckBox();
            this.DifficultClient = new System.Windows.Forms.CheckBox();
            this.PreferredClient = new System.Windows.Forms.CheckBox();
            this.AtCost = new System.Windows.Forms.TextBox();
            this.ClientCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AtCostUnit = new System.Windows.Forms.TextBox();
            this.ClientCostUnit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DesignTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MachineTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManualLabourTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // DesignTime
            // 
            this.DesignTime.Location = new System.Drawing.Point(194, 11);
            this.DesignTime.Name = "DesignTime";
            this.DesignTime.Size = new System.Drawing.Size(100, 20);
            this.DesignTime.TabIndex = 0;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(13, 281);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(281, 23);
            this.Calculate.TabIndex = 1;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Design Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Machine Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Manual Labour Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Material Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Quantity";
            // 
            // MachineTime
            // 
            this.MachineTime.Location = new System.Drawing.Point(194, 41);
            this.MachineTime.Name = "MachineTime";
            this.MachineTime.Size = new System.Drawing.Size(100, 20);
            this.MachineTime.TabIndex = 7;
            // 
            // ManualLabourTime
            // 
            this.ManualLabourTime.Location = new System.Drawing.Point(194, 71);
            this.ManualLabourTime.Name = "ManualLabourTime";
            this.ManualLabourTime.Size = new System.Drawing.Size(100, 20);
            this.ManualLabourTime.TabIndex = 8;
            // 
            // MaterialCost
            // 
            this.MaterialCost.Location = new System.Drawing.Point(194, 101);
            this.MaterialCost.Name = "MaterialCost";
            this.MaterialCost.Size = new System.Drawing.Size(100, 20);
            this.MaterialCost.TabIndex = 9;
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(194, 131);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(100, 20);
            this.Quantity.TabIndex = 10;
            // 
            // RushJob
            // 
            this.RushJob.AutoSize = true;
            this.RushJob.Location = new System.Drawing.Point(13, 175);
            this.RushJob.Name = "RushJob";
            this.RushJob.Size = new System.Drawing.Size(71, 17);
            this.RushJob.TabIndex = 12;
            this.RushJob.Text = "Rush Job";
            this.RushJob.UseVisualStyleBackColor = true;
            // 
            // DifficultClient
            // 
            this.DifficultClient.AutoSize = true;
            this.DifficultClient.Location = new System.Drawing.Point(13, 200);
            this.DifficultClient.Name = "DifficultClient";
            this.DifficultClient.Size = new System.Drawing.Size(90, 17);
            this.DifficultClient.TabIndex = 13;
            this.DifficultClient.Text = "Difficult Client";
            this.DifficultClient.UseVisualStyleBackColor = true;
            // 
            // PreferredClient
            // 
            this.PreferredClient.AutoSize = true;
            this.PreferredClient.Location = new System.Drawing.Point(13, 225);
            this.PreferredClient.Name = "PreferredClient";
            this.PreferredClient.Size = new System.Drawing.Size(150, 17);
            this.PreferredClient.TabIndex = 14;
            this.PreferredClient.Text = "Preferred Client/Bulk Rate";
            this.PreferredClient.UseVisualStyleBackColor = true;
            // 
            // AtCost
            // 
            this.AtCost.Location = new System.Drawing.Point(85, 373);
            this.AtCost.Name = "AtCost";
            this.AtCost.ReadOnly = true;
            this.AtCost.Size = new System.Drawing.Size(100, 20);
            this.AtCost.TabIndex = 16;
            // 
            // ClientCost
            // 
            this.ClientCost.Location = new System.Drawing.Point(194, 373);
            this.ClientCost.Name = "ClientCost";
            this.ClientCost.ReadOnly = true;
            this.ClientCost.Size = new System.Drawing.Size(100, 20);
            this.ClientCost.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "At Cost";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(216, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Client Cost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Per Unit";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Per Order";
            // 
            // AtCostUnit
            // 
            this.AtCostUnit.Location = new System.Drawing.Point(85, 343);
            this.AtCostUnit.Name = "AtCostUnit";
            this.AtCostUnit.ReadOnly = true;
            this.AtCostUnit.Size = new System.Drawing.Size(100, 20);
            this.AtCostUnit.TabIndex = 22;
            // 
            // ClientCostUnit
            // 
            this.ClientCostUnit.Location = new System.Drawing.Point(195, 343);
            this.ClientCostUnit.Name = "ClientCostUnit";
            this.ClientCostUnit.ReadOnly = true;
            this.ClientCostUnit.Size = new System.Drawing.Size(100, 20);
            this.ClientCostUnit.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 407);
            this.Controls.Add(this.ClientCostUnit);
            this.Controls.Add(this.AtCostUnit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ClientCost);
            this.Controls.Add(this.AtCost);
            this.Controls.Add(this.PreferredClient);
            this.Controls.Add(this.DifficultClient);
            this.Controls.Add(this.RushJob);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.MaterialCost);
            this.Controls.Add(this.ManualLabourTime);
            this.Controls.Add(this.MachineTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.DesignTime);
            this.Name = "Form1";
            this.Text = "Quoting Sheet";
            ((System.ComponentModel.ISupportInitialize)(this.DesignTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MachineTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManualLabourTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown DesignTime;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown MachineTime;
        private System.Windows.Forms.NumericUpDown ManualLabourTime;
        private System.Windows.Forms.NumericUpDown MaterialCost;
        private System.Windows.Forms.NumericUpDown Quantity;
        private System.Windows.Forms.CheckBox RushJob;
        private System.Windows.Forms.CheckBox DifficultClient;
        private System.Windows.Forms.CheckBox PreferredClient;
        private System.Windows.Forms.TextBox AtCost;
        private System.Windows.Forms.TextBox ClientCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox AtCostUnit;
        private System.Windows.Forms.TextBox ClientCostUnit;
    }
}

