using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.Text); /*when user click on something on listbox should be showing on messagebox*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text); // When click sur Add button it add from textbox to listbox
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedIndex.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) // -1 is for nothing get selected
                MessageBox.Show("Nothing Selected, Select an Item!");
            else
                MessageBox.Show("Item Selected");
                    }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)  // verdifier if no items selected 
                listBox1.Items.RemoveAt(listBox1.SelectedIndex); // remove the selected item
            else
                MessageBox.Show("You must selecting an item");
            }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();  //delete all the items in listBox
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains(textBox1.Text)) //verify if an item typed in textBox exist on listBox
                MessageBox.Show("Exist");
            else
                MessageBox.Show("Doesn't Exist");
        }
    }
    }

