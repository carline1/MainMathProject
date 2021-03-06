﻿using System;
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
    public partial class DialogPolationForm : Form
    {
        public double a0 = 0;
        public double a1 = 0;
        public double[] x_mass;
        public double[] y_mass;
        public double x_average;
        public double y_average;
        public double y_sigma;
        public bool link;
        public double r;
        public int rel_index = 1; // надежность

        public DialogPolationForm(ShowRegressForm reg)
        {
            InitializeComponent();
            error.Hide();
            a0 = reg.a0;
            a1 = reg.a1;
            x_mass = reg.x_mass;
            y_mass = reg.y_mass;
            x_average = reg.x_average;
            y_average = reg.y_average;
            y_sigma = reg.y_sigma;
            link = reg.link;
            r = reg.r;
        }

        private void interpolation_Click(object sender, EventArgs e)
        {
            try
            {
                if (polation_text.Text == "")
                    error.Show();
                else
                {
                    error.Hide();
                    polation_text.Focus();
                    if (rel95.Checked)
                        rel_index = 1;
                    else if (rel99.Checked)
                        rel_index = 2;
                    PolationForm pol = new PolationForm(this);
                    pol.Show();
                    Hide();
                }
            }
            catch (Exception exp)
            {
                DialogResult result = MessageBox.Show($"Ошибка ввода данных\n{exp.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (result == DialogResult.OK)
                {
                    SetForm_Closed(sender, e);
                }
            }
        }

        protected void SetForm_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
