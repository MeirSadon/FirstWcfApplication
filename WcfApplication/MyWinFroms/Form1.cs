using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinFroms
{
    public partial class Form1 : Form
    {
        private int id;
        public int Id { get { return id; }}
        public Form1()
        {
            InitializeComponent();
        }
        public void RemoveText(object sender, EventArgs e)
        {
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(myTxtbx.Text))
                myTxtbx.Text = "NUUUU";
        }

        private void dataGridView1_NewRowNeeded(object sender, DataGridViewRowEventArgs e)
        {
            id++;
            dataGridView1.Columns[0].HeaderText = id.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
