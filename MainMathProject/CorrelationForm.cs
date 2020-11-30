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
        public double[] x_mass;
        public double[] y_mass;
        int n = 0;  // кол-во комбинаций x y
        public double x_average = 0;  // x среднее
        public double y_average = 0;  // y среднее
        double x_disp = 0;  // дисперсия x
        double y_disp = 0;  // дисперсия y
        public double x_sigma = 0;  // ср квадратич x
        public double y_sigma = 0;  // ср квадратич y
        double r = 0;  // коэфф корреляции
        int df = 0;  // степени свободы
        double t_observ = 0;  // т-критерий наблюдаемый
        double t_table = 0;  // т-критерий табличный
        int rel_index = 1;  // индекс т-критерия
        public double a0 = 0;  // intercept - в ур-е прямой это b
        public double a1 = 0;  // slope - в ур-е прямой это k
        public bool link = false;  // связь между x и y
        public void bubble(double[] x, double[] y)
        {
            for (int i = 0; i < y.Length - 2; i++)
                for (int j = 0; j < y.Length - i - 1; j++)
                    if (y[j] > y[j + 1])
                    {
                        double k = y[j];
                        y[j] = y[j + 1];
                        y[j + 1] = k;
                        k = x[j];
                        x[j] = x[j + 1];
                        x[j + 1] = k;
                    }
        }

        public CorrelationForm(ReliabilityForm rel)
        {
            InitializeComponent();
            x_mass = rel.x_mass;
            y_mass = rel.y_mass;
            n = x_mass.Length;
            rel_index = rel.rel_index;  // индекс в таблице критерия т стьюдента
            bubble(y_mass, x_mass);

            // рассчитываем средние значения
            for (int i = 0; i < n; i++)
            {
                //Console.WriteLine($"{x_mass[i]}, {y_mass[i]}");
                cor_field.Series["point"].Points.AddXY(x_mass[i], y_mass[i]);
                x_average += x_mass[i];
                y_average += y_mass[i];
            }
            x_average = x_average / (double)n;
            y_average = y_average / (double)n;

            // рассчитываем дисперсии
            for (int i = 0; i < n; i++)
            {
                x_disp += Math.Pow((x_mass[i] - x_average), 2);
                y_disp += Math.Pow((y_mass[i] - y_average), 2);
            }
            x_disp = x_disp / (double)n;
            y_disp = y_disp / (double)n;

            // исправляем сигмы
            if (n > 30)
            {
                x_sigma = Math.Sqrt(x_disp);
                y_sigma = Math.Sqrt(y_disp);
            }
            else
            {
                x_sigma = Math.Sqrt(x_disp * (double)n / (double)(n - 1));
                y_sigma = Math.Sqrt(y_disp * (double)n / (double)(n - 1));
            }
            
            // рассчитываем корреляцию
            for (int i = 0; i < n; i++)
            {
                r += (x_mass[i] - x_average) * (y_mass[i] - y_average);
            }
            r = r / (double)((n - 1) * x_sigma * y_sigma);
            r_label.Text = $"r = {r}";

            // рассчет степеней свободы
            df = n - 2;
            // корректировка степеней свободы, т.к. в таблице они с 80 степени идут не через 1
            if (df >= 80 && df < 150)
                df = Decimal.ToInt32(decimal.Round(decimal.Parse(df.ToString()) / 10m, 0, MidpointRounding.AwayFromZero) * 10);
            else if (df >= 150 && df <= 350)
                df = Decimal.ToInt32(decimal.Round(decimal.Parse(df.ToString()) / 50m, 0, MidpointRounding.AwayFromZero) * 50);

            // проверка гипотез
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
                link = true;
                hyp_test.Text = "Между X и Y существует тесная связь";
                comparison_t.Text = $"|t набл| > t табл \n({Math.Abs(t_observ)} > { t_table})";
            }
            else
            {
                link = false;
                hyp_test.Text = "Между X и Y связи нет";
                comparison_t.Text = $"|t набл| < t табл \n({Math.Abs(t_observ)} < { t_table})";
            }

            // уравнение регрессии
            a1 = r * y_sigma / x_sigma;
            a0 = y_average - x_average * a1;
            regress_func.Text = $"y = {a0:F6} + {a1:F6}x";
            
        }

        private void show_regress_Click(object sender, EventArgs e)
        {
            ShowRegressForm reg = new ShowRegressForm(this);
            reg.Show();
            Hide();
        }

        protected void SetForm_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
