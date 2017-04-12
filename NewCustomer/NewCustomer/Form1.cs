using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewCustomer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bokButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "New	Customer Created";
            resultLabel.BackColor = Color.LightGreen;
            resultLabel.Visible = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "Operation Canceled";
            resultLabel.BackColor = Color.HotPink;
            resultLabel.Visible = true;
        }
    }
}
