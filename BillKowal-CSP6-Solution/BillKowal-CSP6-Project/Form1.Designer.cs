namespace BillKowal_CSP6_Project
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
            this.buPlay = new System.Windows.Forms.Button();
            this.buExit = new System.Windows.Forms.Button();
            this.lstbxShow = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buPlay
            // 
            this.buPlay.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buPlay.Location = new System.Drawing.Point(89, 17);
            this.buPlay.Name = "buPlay";
            this.buPlay.Size = new System.Drawing.Size(182, 46);
            this.buPlay.TabIndex = 0;
            this.buPlay.Text = "Play";
            this.buPlay.UseVisualStyleBackColor = true;
            this.buPlay.Click += new System.EventHandler(this.buPlay_Click);
            // 
            // buExit
            // 
            this.buExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buExit.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buExit.Location = new System.Drawing.Point(89, 267);
            this.buExit.Name = "buExit";
            this.buExit.Size = new System.Drawing.Size(182, 46);
            this.buExit.TabIndex = 1;
            this.buExit.Text = "Exit";
            this.buExit.UseVisualStyleBackColor = true;
            this.buExit.Click += new System.EventHandler(this.buExit_Click);
            // 
            // lstbxShow
            // 
            this.lstbxShow.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxShow.FormattingEnabled = true;
            this.lstbxShow.ItemHeight = 16;
            this.lstbxShow.Location = new System.Drawing.Point(25, 87);
            this.lstbxShow.Name = "lstbxShow";
            this.lstbxShow.Size = new System.Drawing.Size(318, 148);
            this.lstbxShow.TabIndex = 2;
            // 
            // Form1
            // 
            this.AcceptButton = this.buPlay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buExit;
            this.ClientSize = new System.Drawing.Size(372, 334);
            this.Controls.Add(this.lstbxShow);
            this.Controls.Add(this.buExit);
            this.Controls.Add(this.buPlay);
            this.Name = "Form1";
            this.Text = "Bill Kowal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buPlay;
        private System.Windows.Forms.Button buExit;
        private System.Windows.Forms.ListBox lstbxShow;
    }
}

