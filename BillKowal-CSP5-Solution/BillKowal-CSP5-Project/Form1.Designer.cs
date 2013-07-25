namespace BillKowal_CSP5_Project
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.chkbxOil = new System.Windows.Forms.CheckBox();
            this.chkbxLube = new System.Windows.Forms.CheckBox();
            this.chkbxTrans = new System.Windows.Forms.CheckBox();
            this.chkbxRadiator = new System.Windows.Forms.CheckBox();
            this.chkbxMuffler = new System.Windows.Forms.CheckBox();
            this.chkbxInspection = new System.Windows.Forms.CheckBox();
            this.chkbxTire = new System.Windows.Forms.CheckBox();
            this.txtbxParts = new System.Windows.Forms.TextBox();
            this.txtbxLabor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblParts = new System.Windows.Forms.Label();
            this.lblSnL = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkbxLube);
            this.groupBox1.Controls.Add(this.chkbxOil);
            this.groupBox1.Location = new System.Drawing.Point(22, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oil and Lube";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkbxTrans);
            this.groupBox2.Controls.Add(this.chkbxRadiator);
            this.groupBox2.Location = new System.Drawing.Point(238, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 84);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flushes";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkbxTire);
            this.groupBox3.Controls.Add(this.chkbxMuffler);
            this.groupBox3.Controls.Add(this.chkbxInspection);
            this.groupBox3.Location = new System.Drawing.Point(22, 135);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(170, 104);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Misc";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtbxLabor);
            this.groupBox4.Controls.Add(this.txtbxParts);
            this.groupBox4.Location = new System.Drawing.Point(238, 135);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(170, 104);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parts and Labor";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblTotal);
            this.groupBox5.Controls.Add(this.lblTax);
            this.groupBox5.Controls.Add(this.lblParts);
            this.groupBox5.Controls.Add(this.lblSnL);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(22, 259);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(386, 161);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Fees Summary";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(81, 443);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(83, 22);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(170, 443);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(83, 22);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(259, 443);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 22);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // chkbxOil
            // 
            this.chkbxOil.AutoSize = true;
            this.chkbxOil.Location = new System.Drawing.Point(7, 20);
            this.chkbxOil.Name = "chkbxOil";
            this.chkbxOil.Size = new System.Drawing.Size(120, 17);
            this.chkbxOil.TabIndex = 0;
            this.chkbxOil.Text = "Oil Change ($26.00)";
            this.chkbxOil.UseVisualStyleBackColor = true;
            // 
            // chkbxLube
            // 
            this.chkbxLube.AutoSize = true;
            this.chkbxLube.Location = new System.Drawing.Point(7, 43);
            this.chkbxLube.Name = "chkbxLube";
            this.chkbxLube.Size = new System.Drawing.Size(109, 17);
            this.chkbxLube.TabIndex = 1;
            this.chkbxLube.Text = "Lube job ($18.00)";
            this.chkbxLube.UseVisualStyleBackColor = true;
            // 
            // chkbxTrans
            // 
            this.chkbxTrans.AutoSize = true;
            this.chkbxTrans.Location = new System.Drawing.Point(6, 42);
            this.chkbxTrans.Name = "chkbxTrans";
            this.chkbxTrans.Size = new System.Drawing.Size(157, 17);
            this.chkbxTrans.TabIndex = 3;
            this.chkbxTrans.Text = "Transmission Flush ($80.00)";
            this.chkbxTrans.UseVisualStyleBackColor = true;
            // 
            // chkbxRadiator
            // 
            this.chkbxRadiator.AutoSize = true;
            this.chkbxRadiator.Location = new System.Drawing.Point(6, 19);
            this.chkbxRadiator.Name = "chkbxRadiator";
            this.chkbxRadiator.Size = new System.Drawing.Size(136, 17);
            this.chkbxRadiator.TabIndex = 2;
            this.chkbxRadiator.Text = "Radiator Flush ($30.00)";
            this.chkbxRadiator.UseVisualStyleBackColor = true;
            // 
            // chkbxMuffler
            // 
            this.chkbxMuffler.AutoSize = true;
            this.chkbxMuffler.Location = new System.Drawing.Point(7, 49);
            this.chkbxMuffler.Name = "chkbxMuffler";
            this.chkbxMuffler.Size = new System.Drawing.Size(149, 17);
            this.chkbxMuffler.TabIndex = 5;
            this.chkbxMuffler.Text = "Replace Muffler ($100.00)";
            this.chkbxMuffler.UseVisualStyleBackColor = true;
            // 
            // chkbxInspection
            // 
            this.chkbxInspection.AutoSize = true;
            this.chkbxInspection.Location = new System.Drawing.Point(7, 26);
            this.chkbxInspection.Name = "chkbxInspection";
            this.chkbxInspection.Size = new System.Drawing.Size(117, 17);
            this.chkbxInspection.TabIndex = 4;
            this.chkbxInspection.Text = "Inspection ($15.00)";
            this.chkbxInspection.UseVisualStyleBackColor = true;
            // 
            // chkbxTire
            // 
            this.chkbxTire.AutoSize = true;
            this.chkbxTire.Location = new System.Drawing.Point(7, 72);
            this.chkbxTire.Name = "chkbxTire";
            this.chkbxTire.Size = new System.Drawing.Size(129, 17);
            this.chkbxTire.TabIndex = 6;
            this.chkbxTire.Text = "Tire Rotation ($20.00)";
            this.chkbxTire.UseVisualStyleBackColor = true;
            // 
            // txtbxParts
            // 
            this.txtbxParts.Location = new System.Drawing.Point(79, 23);
            this.txtbxParts.Name = "txtbxParts";
            this.txtbxParts.Size = new System.Drawing.Size(75, 20);
            this.txtbxParts.TabIndex = 0;
            // 
            // txtbxLabor
            // 
            this.txtbxLabor.Location = new System.Drawing.Point(79, 58);
            this.txtbxLabor.Name = "txtbxLabor";
            this.txtbxLabor.Size = new System.Drawing.Size(75, 20);
            this.txtbxLabor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Parts ($)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Labor Hours";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Service and Labor";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(4, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Parts";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(4, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tax (on parts)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(4, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Total Fees";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(154, 116);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(135, 20);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTax
            // 
            this.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTax.Location = new System.Drawing.Point(154, 83);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(135, 20);
            this.lblTax.TabIndex = 10;
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblParts
            // 
            this.lblParts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblParts.Location = new System.Drawing.Point(154, 52);
            this.lblParts.Name = "lblParts";
            this.lblParts.Size = new System.Drawing.Size(135, 20);
            this.lblParts.TabIndex = 9;
            this.lblParts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSnL
            // 
            this.lblSnL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSnL.Location = new System.Drawing.Point(154, 19);
            this.lblSnL.Name = "lblSnL";
            this.lblSnL.Size = new System.Drawing.Size(135, 20);
            this.lblSnL.TabIndex = 8;
            this.lblSnL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(429, 488);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Bill Kowal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox chkbxLube;
        private System.Windows.Forms.CheckBox chkbxOil;
        private System.Windows.Forms.CheckBox chkbxTrans;
        private System.Windows.Forms.CheckBox chkbxRadiator;
        private System.Windows.Forms.CheckBox chkbxTire;
        private System.Windows.Forms.CheckBox chkbxMuffler;
        private System.Windows.Forms.CheckBox chkbxInspection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxLabor;
        private System.Windows.Forms.TextBox txtbxParts;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.Label lblSnL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

