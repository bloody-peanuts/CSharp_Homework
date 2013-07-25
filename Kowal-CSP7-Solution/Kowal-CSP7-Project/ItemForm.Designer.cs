namespace Kowal_CSP7_Project
{
    partial class ItemForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblItmName = new System.Windows.Forms.Label();
            this.lblItmNum = new System.Windows.Forms.Label();
            this.lblItmCst = new System.Windows.Forms.Label();
            this.lblItmPrc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Name:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Number:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cost:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price:";
            // 
            // lblItmName
            // 
            this.lblItmName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblItmName.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItmName.Location = new System.Drawing.Point(205, 15);
            this.lblItmName.Name = "lblItmName";
            this.lblItmName.Size = new System.Drawing.Size(163, 25);
            this.lblItmName.TabIndex = 4;
            this.lblItmName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblItmNum
            // 
            this.lblItmNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblItmNum.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItmNum.Location = new System.Drawing.Point(205, 50);
            this.lblItmNum.Name = "lblItmNum";
            this.lblItmNum.Size = new System.Drawing.Size(163, 25);
            this.lblItmNum.TabIndex = 5;
            this.lblItmNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblItmCst
            // 
            this.lblItmCst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblItmCst.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItmCst.Location = new System.Drawing.Point(205, 84);
            this.lblItmCst.Name = "lblItmCst";
            this.lblItmCst.Size = new System.Drawing.Size(163, 25);
            this.lblItmCst.TabIndex = 6;
            this.lblItmCst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblItmPrc
            // 
            this.lblItmPrc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblItmPrc.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItmPrc.Location = new System.Drawing.Point(205, 120);
            this.lblItmPrc.Name = "lblItmPrc";
            this.lblItmPrc.Size = new System.Drawing.Size(163, 25);
            this.lblItmPrc.TabIndex = 7;
            this.lblItmPrc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 168);
            this.Controls.Add(this.lblItmPrc);
            this.Controls.Add(this.lblItmCst);
            this.Controls.Add(this.lblItmNum);
            this.Controls.Add(this.lblItmName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ItemForm";
            this.Text = "ItemForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblItmName;
        public System.Windows.Forms.Label lblItmNum;
        public System.Windows.Forms.Label lblItmCst;
        public System.Windows.Forms.Label lblItmPrc;
    }
}