using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_6._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (seri.Checked) 
            {
                ans.Text = (float.Parse(num1.Text) +
                        float.Parse(num2.Text) +
                        float.Parse(num3.Text) +
                        float.Parse(num4.Text) +
                        float.Parse(num5.Text) ).ToString();
            }
                
            if (para.Checked) 
            {
                ans.Text = (1.0 / ((1.0 / float.Parse(num1.Text)) +
                    (1.0 / float.Parse(num2.Text)) +
                    (1.0 / float.Parse(num3.Text)) +
                    (1.0 / float.Parse(num4.Text)) +
                    (1.0 / float.Parse(num5.Text)))).ToString();
            }   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBox[] num = { num1, num2, num3, num4, num5 };
            for (int i = 0; i < num.Length; i++)
                num[i].Text = "";
        } 
    }
}
