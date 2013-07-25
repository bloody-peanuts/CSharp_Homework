namespace Kowal_CSP7_Project
{
    partial class MainForm
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
            this.lbxInventory = new System.Windows.Forms.ListBox();
            this.btnCost = new System.Windows.Forms.Button();
            this.btnName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxInventory
            // 
            this.lbxInventory.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxInventory.FormattingEnabled = true;
            this.lbxInventory.ItemHeight = 18;
            this.lbxInventory.Location = new System.Drawing.Point(27, 27);
            this.lbxInventory.Name = "lbxInventory";
            this.lbxInventory.Size = new System.Drawing.Size(393, 130);
            this.lbxInventory.TabIndex = 0;
            this.lbxInventory.UseCustomTabOffsets = true;
            this.lbxInventory.SelectedIndexChanged += new System.EventHandler(this.lbxInventory_SelectedIndexChanged);
            // 
            // btnCost
            // 
            this.btnCost.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCost.Location = new System.Drawing.Point(27, 187);
            this.btnCost.Name = "btnCost";
            this.btnCost.Size = new System.Drawing.Size(188, 34);
            this.btnCost.TabIndex = 1;
            this.btnCost.Text = "Sort By Cost";
            this.btnCost.UseVisualStyleBackColor = true;
            this.btnCost.Click += new System.EventHandler(this.btnCost_Click);
            // 
            // btnName
            // 
            this.btnName.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnName.Location = new System.Drawing.Point(232, 187);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(188, 34);
            this.btnName.TabIndex = 2;
            this.btnName.Text = "Sort By Name";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 244);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.btnCost);
            this.Controls.Add(this.lbxInventory);
            this.Name = "MainForm";
            this.Text = "Bill Kowal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxInventory;
        private System.Windows.Forms.Button btnCost;
        private System.Windows.Forms.Button btnName;
    }
}

