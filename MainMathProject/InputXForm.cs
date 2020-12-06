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
    public partial class InputXForm : Form
    {
        public InputXForm()
        {
            InitializeComponent();
            success.Hide();
            error.Hide();
        }

        public double[] x_mass;
        int x_iterator = 0;

        private void x_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (x_text.Text == "")
                    error.Show();
                else
                {
                    error.Hide();
                    x_text.Focus();
                    x_mass[x_iterator] = Convert.ToDouble(x_text.Text.Replace('.', ','));
                    x_iterator++;
                    if (x_iterator == x_mass.Length)
                    {
                        x_add.Hide();
                        success.Location = new Point(175, 82);
                        success.Show();
                        return;
                    }
                    x_lable.Text = $"Введите x[{x_iterator + 1}]";
                    if (x_mass[x_iterator] != 0)
                        x_text.Text = $"{x_mass[x_iterator]}";
                    else
                        x_text.Text = "";
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
            InputYForm input_y = new InputYForm(this);
            input_y.Show();
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            x_add.Show();
            success.Hide();
            x_text.Focus();
            if (x_iterator > 0)
            {
                if (x_iterator == x_mass.Length)
                    x_iterator -= 2;
                else
                    x_iterator--;
                x_lable.Text = $"Введите x[{x_iterator + 1}]";
                x_text.Text = $"{x_mass[x_iterator]}";
            }
        }

        protected void SetForm_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
