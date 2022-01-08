using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerEvents2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           // System.Windows.Forms.Timer t;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        void t_Tick(object sender, EventArgs e)
        {
            Timer t = null;
            progressBar1.Value += 10;

            //if (progressBar1.Value >= 100) t.Stop();
            if (progressBar1.Value > 99)
            {
                progressBar1.Value = 0;
            }
            /*
            progressBar1.Value += 1;
            trackBar1.Value = progressBar1.hjValue;
            progressBar3.Value = 100 - progressBar1.Value;*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer t;
            t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);
            t.Start();

        }
    }
}
