namespace Battery_Manager
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
            this.components = new System.ComponentModel.Container();
            this.CurrentCharge = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentTimeT = new System.Windows.Forms.TextBox();
            this.StatusT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeLeftT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.NewTimeB = new System.Windows.Forms.Button();
            this.NewTimeT = new System.Windows.Forms.TextBox();
            this.CurrentChargeL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CurrentCharge
            // 
            this.CurrentCharge.Location = new System.Drawing.Point(12, 22);
            this.CurrentCharge.Name = "CurrentCharge";
            this.CurrentCharge.Size = new System.Drawing.Size(245, 23);
            this.CurrentCharge.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current time";
            // 
            // CurrentTimeT
            // 
            this.CurrentTimeT.Enabled = false;
            this.CurrentTimeT.Location = new System.Drawing.Point(12, 74);
            this.CurrentTimeT.Name = "CurrentTimeT";
            this.CurrentTimeT.Size = new System.Drawing.Size(245, 20);
            this.CurrentTimeT.TabIndex = 2;
            this.CurrentTimeT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StatusT
            // 
            this.StatusT.Enabled = false;
            this.StatusT.Location = new System.Drawing.Point(12, 124);
            this.StatusT.Name = "StatusT";
            this.StatusT.Size = new System.Drawing.Size(245, 20);
            this.StatusT.TabIndex = 4;
            this.StatusT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Power status";
            // 
            // TimeLeftT
            // 
            this.TimeLeftT.Enabled = false;
            this.TimeLeftT.Location = new System.Drawing.Point(12, 171);
            this.TimeLeftT.Name = "TimeLeftT";
            this.TimeLeftT.Size = new System.Drawing.Size(245, 20);
            this.TimeLeftT.TabIndex = 6;
            this.TimeLeftT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Time left";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // NewTimeB
            // 
            this.NewTimeB.Location = new System.Drawing.Point(182, 209);
            this.NewTimeB.Name = "NewTimeB";
            this.NewTimeB.Size = new System.Drawing.Size(75, 31);
            this.NewTimeB.TabIndex = 7;
            this.NewTimeB.Text = "Set";
            this.NewTimeB.UseVisualStyleBackColor = true;
            this.NewTimeB.Click += new System.EventHandler(this.NewTimeB_Click);
            // 
            // NewTimeT
            // 
            this.NewTimeT.Location = new System.Drawing.Point(12, 215);
            this.NewTimeT.Name = "NewTimeT";
            this.NewTimeT.Size = new System.Drawing.Size(142, 20);
            this.NewTimeT.TabIndex = 8;
            // 
            // CurrentChargeL
            // 
            this.CurrentChargeL.AutoSize = true;
            this.CurrentChargeL.Location = new System.Drawing.Point(122, 3);
            this.CurrentChargeL.Name = "CurrentChargeL";
            this.CurrentChargeL.Size = new System.Drawing.Size(0, 13);
            this.CurrentChargeL.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 244);
            this.Controls.Add(this.CurrentChargeL);
            this.Controls.Add(this.NewTimeT);
            this.Controls.Add(this.NewTimeB);
            this.Controls.Add(this.TimeLeftT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StatusT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CurrentTimeT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CurrentCharge);
            this.Name = "Form1";
            this.Text = "Battery manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar CurrentCharge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CurrentTimeT;
        private System.Windows.Forms.TextBox StatusT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TimeLeftT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button NewTimeB;
        private System.Windows.Forms.TextBox NewTimeT;
        private System.Windows.Forms.Label CurrentChargeL;
    }
}

