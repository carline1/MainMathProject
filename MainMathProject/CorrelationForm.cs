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
    public partial class CorrelationForm : Form
    {
        public int[] x_mass;
        public int[] y_mass;
        int n = 0; 
        double x_average = 0;  // x среднее
        double y_average = 0;  // y среднее
        double x_disp = 0;  // дисперсия x
        double y_disp = 0;  // дисперсия y
        double x_sigma = 0;  // ср квадратич x
        double y_sigma = 0;  // ср квадратич y
        double r = 0;  // коэфф корреляции
        int df = 0;  // степени свободы
        double t_observ = 0;  // т-критерий наблюдаемый
        double t_table = 0;  // т-критерий табличный
        int rel_index = 1;
        public CorrelationForm(ReliabilityForm rel)
        {
            InitializeComponent();
            x_mass = rel.x_mass;
            y_mass = rel.y_mass;
            n = x_mass.Length;
            rel_index = rel.rel_index;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{x_mass[i]}, {y_mass[i]}");
                cor_field.Series["point"].Points.AddXY(x_mass[i], y_mass[i]);
                x_average += x_mass[i];
                y_average += y_mass[i];
            }
            x_average = x_average / (double)n;
            y_average = y_average / (double)y_mass.Length;

            for (int i = 0; i < n; i++)
            {
                x_disp += Math.Pow((x_mass[i] - x_average), 2);
                y_disp += Math.Pow((y_mass[i] - y_average), 2);
            }
            x_disp = x_disp / (double)n;
            y_disp = y_disp / (double)y_mass.Length;

            x_sigma = Math.Sqrt(x_disp);
            y_sigma = Math.Sqrt(y_disp);

            for (int i = 0; i < n; i++)
            {
                r += (x_mass[i] - x_average) * (y_mass[i] - y_average);
            }
            r = r / (double)(n * x_sigma * y_sigma);
            r_label.Text = $"r = {r}";

            df = n - 2;
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
            t_observ = (double)(r * Math.Sqrt(n - 2) / (double)(Math.Sqrt(1 - Math.Pow(r, 2))));
            if (Math.Abs(t_observ) > t_table)
            {
                hyp_test.Text = "Между X и Y существует тесная связь";
                comparison_t.Text = $"|t набл| > t табл \n({Math.Abs(t_observ)} > { t_table})";
            }
            else
            {
                hyp_test.Text = "Между X и Y связи нет";
                comparison_t.Text = $"|t набл| < t табл \n({Math.Abs(t_observ)} < { t_table})";
            }
        }

        protected void SetForm_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
