namespace BillKowal_CSP1_Project
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.campusPicbox = new System.Windows.Forms.PictureBox();
            this.warwickBtn = new System.Windows.Forms.Button();
            this.lincolnBtn = new System.Windows.Forms.Button();
            this.newportBtn = new System.Windows.Forms.Button();
            this.providenceBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.campusPicbox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(84, 34);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(250, 74);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "View the CCRI Campuses";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // campusPicbox
            // 
            this.campusPicbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.campusPicbox.Image = global::BillKowal_CSP1_Project.Properties.Resources.campus_prov;
            this.campusPicbox.Location = new System.Drawing.Point(142, 129);
            this.campusPicbox.Name = "campusPicbox";
            this.campusPicbox.Size = new System.Drawing.Size(154, 225);
            this.campusPicbox.TabIndex = 1;
            this.campusPicbox.TabStop = false;
            // 
            // warwickBtn
            // 
            this.warwickBtn.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warwickBtn.ForeColor = System.Drawing.Color.Black;
            this.warwickBtn.Location = new System.Drawing.Point(76, 379);
            this.warwickBtn.Name = "warwickBtn";
            this.warwickBtn.Size = new System.Drawing.Size(136, 35);
            this.warwickBtn.TabIndex = 2;
            this.warwickBtn.Text = "WARWICK";
            this.warwickBtn.UseVisualStyleBackColor = true;
            this.warwickBtn.Click += new System.EventHandler(this.warwickBtn_Click);
            // 
            // lincolnBtn
            // 
            this.lincolnBtn.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lincolnBtn.Location = new System.Drawing.Point(76, 420);
            this.lincolnBtn.Name = "lincolnBtn";
            this.lincolnBtn.Size = new System.Drawing.Size(136, 35);
            this.lincolnBtn.TabIndex = 3;
            this.lincolnBtn.Text = "LINCOLN";
            this.lincolnBtn.UseVisualStyleBackColor = true;
            this.lincolnBtn.Click += new System.EventHandler(this.lincolnBtn_Click);
            // 
            // newportBtn
            // 
            this.newportBtn.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newportBtn.Location = new System.Drawing.Point(231, 420);
            this.newportBtn.Name = "newportBtn";
            this.newportBtn.Size = new System.Drawing.Size(136, 35);
            this.newportBtn.TabIndex = 4;
            this.newportBtn.Text = "NEWPORT";
            this.newportBtn.UseVisualStyleBackColor = true;
            this.newportBtn.Click += new System.EventHandler(this.newportBtn_Click);
            // 
            // providenceBtn
            // 
            this.providenceBtn.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.providenceBtn.Location = new System.Drawing.Point(231, 379);
            this.providenceBtn.Name = "providenceBtn";
            this.providenceBtn.Size = new System.Drawing.Size(136, 35);
            this.providenceBtn.TabIndex = 5;
            this.providenceBtn.Text = "PROVIDENCE";
            this.providenceBtn.UseVisualStyleBackColor = true;
            this.providenceBtn.Click += new System.EventHandler(this.providenceBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(149, 476);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(136, 35);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 540);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.providenceBtn);
            this.Controls.Add(this.newportBtn);
            this.Controls.Add(this.lincolnBtn);
            this.Controls.Add(this.warwickBtn);
            this.Controls.Add(this.campusPicbox);
            this.Controls.Add(this.titleLbl);
            this.Name = "Form1";
            this.Text = "Bill Kowal";
            ((System.ComponentModel.ISupportInitialize)(this.campusPicbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.PictureBox campusPicbox;
        private System.Windows.Forms.Button warwickBtn;
        private System.Windows.Forms.Button lincolnBtn;
        private System.Windows.Forms.Button newportBtn;
        private System.Windows.Forms.Button providenceBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

