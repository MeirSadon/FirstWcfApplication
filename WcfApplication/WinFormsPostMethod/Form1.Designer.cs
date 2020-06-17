namespace WinFormsPostMethod
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
            this.SNameLbl = new System.Windows.Forms.Label();
            this.SDepartmentLbl = new System.Windows.Forms.Label();
            this.SAddressLbl = new System.Windows.Forms.Label();
            this.SMobileLbl = new System.Windows.Forms.Label();
            this.SNameTxtbx = new System.Windows.Forms.TextBox();
            this.SDepartmentTxtbx = new System.Windows.Forms.TextBox();
            this.SAddressTxtbx = new System.Windows.Forms.TextBox();
            this.SMobileTxtbx = new System.Windows.Forms.TextBox();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SNameLbl
            // 
            this.SNameLbl.AutoSize = true;
            this.SNameLbl.Location = new System.Drawing.Point(42, 57);
            this.SNameLbl.Margin = new System.Windows.Forms.Padding(20, 20, 30, 20);
            this.SNameLbl.Name = "SNameLbl";
            this.SNameLbl.Size = new System.Drawing.Size(38, 13);
            this.SNameLbl.TabIndex = 0;
            this.SNameLbl.Text = "Name:";
            // 
            // SDepartmentLbl
            // 
            this.SDepartmentLbl.AutoSize = true;
            this.SDepartmentLbl.Location = new System.Drawing.Point(42, 94);
            this.SDepartmentLbl.Margin = new System.Windows.Forms.Padding(20, 20, 30, 20);
            this.SDepartmentLbl.Name = "SDepartmentLbl";
            this.SDepartmentLbl.Size = new System.Drawing.Size(65, 13);
            this.SDepartmentLbl.TabIndex = 1;
            this.SDepartmentLbl.Text = "Department:";
            // 
            // SAddressLbl
            // 
            this.SAddressLbl.AutoSize = true;
            this.SAddressLbl.Location = new System.Drawing.Point(42, 132);
            this.SAddressLbl.Margin = new System.Windows.Forms.Padding(20, 20, 30, 20);
            this.SAddressLbl.Name = "SAddressLbl";
            this.SAddressLbl.Size = new System.Drawing.Size(48, 13);
            this.SAddressLbl.TabIndex = 2;
            this.SAddressLbl.Text = "Address:";
            // 
            // SMobileLbl
            // 
            this.SMobileLbl.AutoSize = true;
            this.SMobileLbl.Location = new System.Drawing.Point(42, 171);
            this.SMobileLbl.Margin = new System.Windows.Forms.Padding(20, 20, 30, 20);
            this.SMobileLbl.Name = "SMobileLbl";
            this.SMobileLbl.Size = new System.Drawing.Size(41, 13);
            this.SMobileLbl.TabIndex = 3;
            this.SMobileLbl.Text = "Mobile:";
            // 
            // SNameTxtbx
            // 
            this.SNameTxtbx.Location = new System.Drawing.Point(109, 57);
            this.SNameTxtbx.Name = "SNameTxtbx";
            this.SNameTxtbx.Size = new System.Drawing.Size(133, 20);
            this.SNameTxtbx.TabIndex = 4;
            // 
            // SDepartmentTxtbx
            // 
            this.SDepartmentTxtbx.Location = new System.Drawing.Point(109, 91);
            this.SDepartmentTxtbx.Name = "SDepartmentTxtbx";
            this.SDepartmentTxtbx.Size = new System.Drawing.Size(133, 20);
            this.SDepartmentTxtbx.TabIndex = 5;
            // 
            // SAddressTxtbx
            // 
            this.SAddressTxtbx.Location = new System.Drawing.Point(109, 132);
            this.SAddressTxtbx.Name = "SAddressTxtbx";
            this.SAddressTxtbx.Size = new System.Drawing.Size(133, 20);
            this.SAddressTxtbx.TabIndex = 6;
            // 
            // SMobileTxtbx
            // 
            this.SMobileTxtbx.Location = new System.Drawing.Point(109, 171);
            this.SMobileTxtbx.Name = "SMobileTxtbx";
            this.SMobileTxtbx.Size = new System.Drawing.Size(133, 20);
            this.SMobileTxtbx.TabIndex = 7;
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.TitleLbl.Location = new System.Drawing.Point(60, 9);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(164, 29);
            this.TitleLbl.TabIndex = 8;
            this.TitleLbl.Text = "New Student:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(96, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 255);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.SMobileTxtbx);
            this.Controls.Add(this.SAddressTxtbx);
            this.Controls.Add(this.SDepartmentTxtbx);
            this.Controls.Add(this.SNameTxtbx);
            this.Controls.Add(this.SMobileLbl);
            this.Controls.Add(this.SAddressLbl);
            this.Controls.Add(this.SDepartmentLbl);
            this.Controls.Add(this.SNameLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SNameLbl;
        private System.Windows.Forms.Label SDepartmentLbl;
        private System.Windows.Forms.Label SAddressLbl;
        private System.Windows.Forms.Label SMobileLbl;
        private System.Windows.Forms.TextBox SNameTxtbx;
        private System.Windows.Forms.TextBox SDepartmentTxtbx;
        private System.Windows.Forms.TextBox SAddressTxtbx;
        private System.Windows.Forms.TextBox SMobileTxtbx;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Button button1;
    }
}

