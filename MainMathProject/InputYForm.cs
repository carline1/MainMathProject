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
    public partial class InputYForm : Form
    {

        public double[] y_mass;
        public double[] x_mass;

        public InputYForm(InputXForm input_x)
        {
            InitializeComponent();
            success.Hide();
            error.Hide();
            x_mass = input_x.x_mass;
            y_mass = new double[input_x.x_mass.Length];
        }

        int y_iterator = 0;        

        private void y_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (y_text.Text == "")
                    error.Show();
                else
                {
                    error.Hide();
                    y_text.Focus();
                    y_mass[y_iterator] = Convert.ToDouble(y_text.Text.Replace('.', ','));
                    y_iterator++;
                    if (y_iterator == y_mass.Length)
                    {
                        y_add.Hide();
                        success.Location = new Point(175, 82);
                        success.Show();
                        return;
                    }
                    y_lable.Text = $"Введите y[{y_iterator + 1}]";
                    if (y_mass[y_iterator] != 0)
                        y_text.Text = $"{y_mass[y_iterator]}";
                    else
                        y_text.Text = "";
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

        private void success_Click(object sender, EventArgs e)
        {
            ReliabilityForm rel = new ReliabilityForm(this);
            rel.Show();
            Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            y_add.Show();
            success.Hide();
            y_text.Focus();
            if (y_iterator > 0)
            {
                if (y_iterator == y_mass.Length)
                    y_iterator -= 2;
                else
                    y_iterator--;
                y_lable.Text = $"Введите y[{y_iterator + 1}]";
                y_text.Text = $"{y_mass[y_iterator]}";
            }  
        }

        protected void SetForm_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
