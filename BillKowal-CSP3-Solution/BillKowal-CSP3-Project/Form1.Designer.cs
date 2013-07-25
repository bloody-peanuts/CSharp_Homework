namespace BillKowal_CSP3_Project
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
            this.LstBxWorkshop = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadBuReturn = new System.Windows.Forms.RadioButton();
            this.RadBuStudent = new System.Windows.Forms.RadioButton();
            this.RadBuSenior = new System.Windows.Forms.RadioButton();
            this.ChkBxInternet = new System.Windows.Forms.CheckBox();
            this.ChkBxValet = new System.Windows.Forms.CheckBox();
            this.ChkBxGym = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LstBxLocation = new System.Windows.Forms.ListBox();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblRegis = new System.Windows.Forms.Label();
            this.LblLodging = new System.Windows.Forms.Label();
            this.LblFees = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LstBxWorkshop
            // 
            this.LstBxWorkshop.FormattingEnabled = true;
            this.LstBxWorkshop.Items.AddRange(new object[] {
            "Handling Stress        3 days    $1,000",
            "Time Management   3 days    $800",
            "Supervision Skills     3 days    $1,500",
            "Negotiation               5 days   $1,300",
            "How to Interview      1 day     $500"});
            this.LstBxWorkshop.Location = new System.Drawing.Point(26, 37);
            this.LstBxWorkshop.Name = "LstBxWorkshop";
            this.LstBxWorkshop.Size = new System.Drawing.Size(210, 69);
            this.LstBxWorkshop.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChkBxGym);
            this.groupBox1.Controls.Add(this.ChkBxValet);
            this.groupBox1.Controls.Add(this.ChkBxInternet);
            this.groupBox1.Controls.Add(this.RadBuSenior);
            this.groupBox1.Controls.Add(this.RadBuStudent);
            this.groupBox1.Controls.Add(this.RadBuReturn);
            this.groupBox1.Location = new System.Drawing.Point(26, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 108);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPTIONS";
            // 
            // RadBuReturn
            // 
            this.RadBuReturn.AutoSize = true;
            this.RadBuReturn.Location = new System.Drawing.Point(6, 19);
            this.RadBuReturn.Name = "RadBuReturn";
            this.RadBuReturn.Size = new System.Drawing.Size(192, 17);
            this.RadBuReturn.TabIndex = 0;
            this.RadBuReturn.TabStop = true;
            this.RadBuReturn.Text = "Returning Customer Discount (10%)";
            this.RadBuReturn.UseVisualStyleBackColor = true;
            // 
            // RadBuStudent
            // 
            this.RadBuStudent.AutoSize = true;
            this.RadBuStudent.Location = new System.Drawing.Point(6, 50);
            this.RadBuStudent.Name = "RadBuStudent";
            this.RadBuStudent.Size = new System.Drawing.Size(136, 17);
            this.RadBuStudent.TabIndex = 1;
            this.RadBuStudent.TabStop = true;
            this.RadBuStudent.Text = "Student Discount (40%)";
            this.RadBuStudent.UseVisualStyleBackColor = true;
            // 
            // RadBuSenior
            // 
            this.RadBuSenior.AutoSize = true;
            this.RadBuSenior.Location = new System.Drawing.Point(6, 84);
            this.RadBuSenior.Name = "RadBuSenior";
            this.RadBuSenior.Size = new System.Drawing.Size(129, 17);
            this.RadBuSenior.TabIndex = 2;
            this.RadBuSenior.TabStop = true;
            this.RadBuSenior.Text = "Senior Discount (20%)";
            this.RadBuSenior.UseVisualStyleBackColor = true;
            // 
            // ChkBxInternet
            // 
            this.ChkBxInternet.AutoSize = true;
            this.ChkBxInternet.Location = new System.Drawing.Point(219, 19);
            this.ChkBxInternet.Name = "ChkBxInternet";
            this.ChkBxInternet.Size = new System.Drawing.Size(149, 17);
            this.ChkBxInternet.TabIndex = 3;
            this.ChkBxInternet.Text = "Internet Access ($12/day)";
            this.ChkBxInternet.UseVisualStyleBackColor = true;
            // 
            // ChkBxValet
            // 
            this.ChkBxValet.AutoSize = true;
            this.ChkBxValet.Location = new System.Drawing.Point(219, 51);
            this.ChkBxValet.Name = "ChkBxValet";
            this.ChkBxValet.Size = new System.Drawing.Size(138, 17);
            this.ChkBxValet.TabIndex = 4;
            this.ChkBxValet.Text = "Valet Parking ($15/day)";
            this.ChkBxValet.UseVisualStyleBackColor = true;
            // 
            // ChkBxGym
            // 
            this.ChkBxGym.AutoSize = true;
            this.ChkBxGym.Location = new System.Drawing.Point(219, 85);
            this.ChkBxGym.Name = "ChkBxGym";
            this.ChkBxGym.Size = new System.Drawing.Size(134, 17);
            this.ChkBxGym.TabIndex = 5;
            this.ChkBxGym.Text = "Gym Access ($10/day)";
            this.ChkBxGym.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LblTotal);
            this.panel1.Controls.Add(this.LblFees);
            this.panel1.Controls.Add(this.LblLodging);
            this.panel1.Controls.Add(this.LblRegis);
            this.panel1.Location = new System.Drawing.Point(26, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 86);
            this.panel1.TabIndex = 2;
            // 
            // LstBxLocation
            // 
            this.LstBxLocation.FormattingEnabled = true;
            this.LstBxLocation.Items.AddRange(new object[] {
            "Austin\t$150",
            "Chicago\t$225",
            "Dallas\t$175",
            "Orlando\t$300",
            "Phoenix\t$175",
            "Raleigh\t$150"});
            this.LstBxLocation.Location = new System.Drawing.Point(290, 37);
            this.LstBxLocation.Name = "LstBxLocation";
            this.LstBxLocation.Size = new System.Drawing.Size(120, 69);
            this.LstBxLocation.TabIndex = 3;
            // 
            // BtnCalc
            // 
            this.BtnCalc.Location = new System.Drawing.Point(298, 253);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(107, 25);
            this.BtnCalc.TabIndex = 4;
            this.BtnCalc.Text = "Calculate";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(298, 283);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(107, 25);
            this.BtnReset.TabIndex = 5;
            this.BtnReset.Text = "Reset Form";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnExit.Location = new System.Drawing.Point(298, 314);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(107, 25);
            this.BtnExit.TabIndex = 6;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Workshop / No of Days / Registration Fee";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(287, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Location / Lodging Fees";
            // 
            // LblRegis
            // 
            this.LblRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegis.Location = new System.Drawing.Point(1, 2);
            this.LblRegis.Name = "LblRegis";
            this.LblRegis.Size = new System.Drawing.Size(249, 21);
            this.LblRegis.TabIndex = 0;
            // 
            // LblLodging
            // 
            this.LblLodging.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLodging.Location = new System.Drawing.Point(1, 23);
            this.LblLodging.Name = "LblLodging";
            this.LblLodging.Size = new System.Drawing.Size(249, 21);
            this.LblLodging.TabIndex = 1;
            // 
            // LblFees
            // 
            this.LblFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFees.Location = new System.Drawing.Point(1, 44);
            this.LblFees.Name = "LblFees";
            this.LblFees.Size = new System.Drawing.Size(249, 21);
            this.LblFees.TabIndex = 2;
            // 
            // LblTotal
            // 
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(2, 64);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(249, 21);
            this.LblTotal.TabIndex = 3;
            // 
            // Form1
            // 
            this.AcceptButton = this.BtnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnExit;
            this.ClientSize = new System.Drawing.Size(442, 363);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.LstBxLocation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LstBxWorkshop);
            this.Name = "Form1";
            this.Text = "Bill Kowal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstBxWorkshop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadBuStudent;
        private System.Windows.Forms.RadioButton RadBuReturn;
        private System.Windows.Forms.CheckBox ChkBxGym;
        private System.Windows.Forms.CheckBox ChkBxValet;
        private System.Windows.Forms.CheckBox ChkBxInternet;
        private System.Windows.Forms.RadioButton RadBuSenior;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox LstBxLocation;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblFees;
        private System.Windows.Forms.Label LblLodging;
        private System.Windows.Forms.Label LblRegis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

