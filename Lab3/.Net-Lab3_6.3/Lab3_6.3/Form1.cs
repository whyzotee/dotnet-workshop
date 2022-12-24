using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_6._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ohm.Checked) 
            {
                if (ohm_2.Checked) 
                {
                    num_2.Text = num_1.Text;
                    value.Text = "uF (MicroFarad)";
                }
                if (k_ohm_2.Checked) 
                {
                    num_2.Text = (float.Parse(num_1.Text) / 1000000000).ToString();
                    value.Text = "kF (KiloFarad)";
                }
                if (m_ohm_2.Checked) 
                {
                    num_2.Text = (float.Parse(num_1.Text) / 1000).ToString();
                    value.Text = "mF (MilliFarad)";
                }
            }

            if (k_ohm.Checked)
            {
                if (ohm_2.Checked)
                {
                    num_2.Text = (float.Parse(num_1.Text) * 1000000000).ToString();
                    value.Text = "uF (MicroFarad)";
                }
                if (k_ohm_2.Checked)
                {
                    num_2.Text = num_1.Text;
                    value.Text = "kF (KiloFarad)";
                }
                if (m_ohm_2.Checked)
                {
                    num_2.Text = (float.Parse(num_1.Text) * 1000000).ToString();
                    value.Text = "mF (MilliFarad)";
                }
            }
            if (m_ohm.Checked)
            {
                if (ohm_2.Checked)
                {
                    num_2.Text = (float.Parse(num_1.Text) * 1000).ToString();
                    value.Text = "uF (MicroFarad)";
                }
                if (k_ohm_2.Checked)
                {
                    num_2.Text = (float.Parse(num_1.Text) / 1000000).ToString();
                    value.Text = "kF (KiloFarad)";
                }
                if (m_ohm_2.Checked)
                {
                    num_2.Text = num_1.Text;
                    value.Text = "mF (MilliFarad)";
                }
            }
        }
    }
}
