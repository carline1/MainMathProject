using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMathProject
{
    public partial class ReliabilityForm : Form
    {
        public double[] y_mass;
        public double[] x_mass;
        public int rel_index;  // идедекс надежности в csv файле с t-критерием 

        public ReliabilityForm(InputYForm input_y)
        {
            InitializeComponent();
            x_mass = input_y.x_mass;
            y_mass = input_y.y_mass;
        }

        private void rel95_Click(object sender, EventArgs e)
        {
            rel_index = 1;
            CorrelationForm cor = new CorrelationForm(this);
            cor.Show();
            Hide();
        }

        private void rel99_Click(object sender, EventArgs e)
        {
            rel_index = 2;
            CorrelationForm cor = new CorrelationForm(this);
            cor.Show();
            Hide();
        }
        protected void SetForm_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
