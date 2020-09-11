using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diet.Presentation_Layer
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            try
            {
                ProductFunc.Add_NewProduct(fm.treeView1, textBox1.Text, Convert.ToInt32(textBox2.Text),
                    Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text),
                    Convert.ToDouble(textBox6.Text), Convert.ToInt32(textBox7.Text));
            }
            catch { return; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
