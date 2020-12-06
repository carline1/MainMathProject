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
    public partial class InputNForm : Form
    {
        public InputNForm()
        {
            InitializeComponent();
            error.Hide();
            error_outside.Hide();
        }

        private void n_quant_Click(object sender, EventArgs e)
        {
            try
            {
                if (n_text.Text == "")
                {
                    error_outside.Hide();
                    error.Show();
                }
                else if (Int32.Parse(n_text.Text) < 2)
                {
                    error_outside.Hide();
                    error.Show();
                }
                else if (Int32.Parse(n_text.Text) > 374)
                {
                    error.Hide();
                    error_outside.Location = new Point(100, 117);
                    error_outside.Show();
                }
                else
                {
                    error.Hide();
                    InputXForm input_x = new InputXForm();
                    input_x.x_mass = new double[Int32.Parse(n_text.Text)];
                    input_x.Show();
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
