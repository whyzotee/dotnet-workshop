using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab3_6._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox.SelectedIndex) 
            {
                case 0:
                    num2.Text = (float.Parse(num1.Text) * 34.73).ToString();
                    break;
                case 1:
                    num2.Text = (float.Parse(num1.Text) * 0.26).ToString();
                    break;
                case 2:
                    num2.Text = (float.Parse(num1.Text) * 37.00).ToString();
                    break;
                case 3:
                    num2.Text = (float.Parse(num1.Text) * 25.75).ToString();
                    break;
                case 4:
                    num2.Text = (float.Parse(num1.Text) * 0.0020).ToString();
                    break;
                case 5:
                    num2.Text = (float.Parse(num1.Text) * 1.14).ToString();
                    break;
            }
            
        }
    }
}
