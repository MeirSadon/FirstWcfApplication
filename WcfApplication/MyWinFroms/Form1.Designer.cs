namespace MyWinFroms
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
            this.myTxtbx = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cascas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // myTxtbx
            // 
            this.myTxtbx.Location = new System.Drawing.Point(160, 52);
            this.myTxtbx.Name = "myTxtbx";
            this.myTxtbx.Size = new System.Drawing.Size(100, 20);
            this.myTxtbx.TabIndex = 0;
            this.myTxtbx.Text = "Your Name...";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cascas,
            this.Dd,
            this.assac});
            this.dataGridView1.DataSource = this.customerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(89, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.NewRowNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_NewRowNeeded);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(MyWinFroms.Form1);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(MyWinFroms.Customer);
            // 
            // cascas
            // 
            this.cascas.HeaderText = "Id";
            this.cascas.Name = "cascas";
            // 
            // Dd
            // 
            this.Dd.HeaderText = "Name";
            this.Dd.Name = "Dd";
            // 
            // assac
            // 
            this.assac.HeaderText = "Age";
            this.assac.Name = "assac";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.myTxtbx);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox myTxtbx;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cascas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dd;
        private System.Windows.Forms.DataGridViewTextBoxColumn assac;
    }
}

