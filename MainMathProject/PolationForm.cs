using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMathProject
{
    public partial class PolationForm : Form
    {
        double a0;
        double a1;
        int rel_index;
        double[] x_mass;
        double[] y_mass;
        double x_average;
        int n;

        public PolationForm(DialogPolationForm dialog)
        {
            InitializeComponent();
            exist_val_text.Hide();
            exist_val.Hide();
            a0 = dialog.a0; 
            a1 = dialog.a1;
            rel_index = dialog.rel_index;
            x_mass = dialog.x_mass;
            y_mass = dialog.y_mass;
            x_average = dialog.x_average;
            n = x_mass.Length;
            int df = n - 2;
            double value = double.Parse(dialog.polation_text.Text.Replace('.', ','));
            double regression(double x)
            {
                return a0 + a1 * x;
            }
            // рассчитаем точное значение
            double y_hat = regression(value);
            // определим среднюю квадратичную уравнения
            double sxy = 0;
            for(int i = 0; i < n; i++)
                sxy += Math.Pow(y_mass[i] - regression(x_mass[i]), 2);
            sxy = Math.Sqrt(sxy / (double)(n - 2));
            // найдем значение
            double xpow2 = 0;
            for (int i = 0; i < n; i++)
                xpow2 += Math.Pow(x_mass[i], 2);
            double h0 = (1.0 / n) + (Math.Pow((value - x_average), 2) / (xpow2 - Math.Pow(x_average, 2)));

            double t_table = 0; // t табличное
            var sr = new StreamReader("t.csv");
            while (!sr.EndOfStream)
            {
                string[] components = sr.ReadLine().Split(';');
                if (Int32.Parse(components[0]) == df)
                {
                    t_table = Double.Parse(components[rel_index].Trim(' '));
                    break;
                }
            }
            double delta = t_table * Math.Sqrt(h0) * sxy;
            double left_border = y_hat - delta;  // левая граница доверительного интервала
            double right_border = y_hat + delta;  // правая граница доверительного интервала
            bool value_in_mass = false;  // проверка наличия введенного числа в массиве x
            int exist_val_index = 0;
            for (int i = 0; i < n; i++)
            {
                if (x_mass[i] == value)
                {
                    value_in_mass = true;
                    exist_val_index = i;
                    break;
                }
            }
            if (value_in_mass)
            {
                exist_val_text.Show();
                exist_val.Show();
                pol_text.Hide();
                label1.Hide();
                pol_value.Hide();
                exist_val_text.Location = new Point(50, 45);
                exist_val.Location = new Point(165, 85);
                exist_val.Text = $"y[{value}] = {y_mass[exist_val_index]}";
            }
            else
            {
                /*Console.WriteLine(sxy);
                Console.WriteLine(h0);
                Console.WriteLine(t_table);
                Console.WriteLine(delta);*/
                if (value > x_mass.Max() || value < x_mass.Min())
                    pol_text.Text = $"Экстраполяция";
                else if (value < x_mass.Max())
                    pol_text.Text = $"Интерполяция";
                if (rel_index == 1)
                    pol_value.Text = $"[{left_border:F4};{right_border:F4}] с надежностью 95%";
                if (rel_index == 2)
                    pol_value.Text = $"[{left_border};{right_border}] с надежностью 99%";
            }
        }

        protected void SetForm_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
