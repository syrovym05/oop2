using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukol2oop
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            Button1.Enabled = false;
            Button2.Enabled = false;
            button4.Enabled = false;
            label4.Text = "0 tun";
        }

        NakladniAuto auto;

        private void button1_Click(object sender, EventArgs e)
        {
            auto.NalozNaklad((int)numericUpDown1.Value);
            label4.Text = auto.HmotnostNakladu + " tun";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            auto.VylozNaklad((int)numericUpDown2.Value);
            label4.Text = auto.HmotnostNakladu + " tun";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {            
            auto = new NakladniAuto(textBox1.Text, (int)numericUpDown3.Value);
            Button1.Enabled = true;
            Button2.Enabled = true;
            button4.Enabled = true;
            label4.Text = "0 tun";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label5.Text = auto.ToString();
            
        }
    }
}
