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
    public partial class ShowRegressForm : Form
    {
        public double[] x_mass;
        public double[] y_mass;
        double y_average;
        public double x_average;
        double y_sigma;
        public double a0 = 0;
        public double a1 = 0;
        int n = 0;
        double[] y_residuals;  // остатки
        public bool link;
        public ShowRegressForm(CorrelationForm cor)
        {
            InitializeComponent();
            x_mass = cor.x_mass;
            y_mass = cor.y_mass;
            n = x_mass.Length;
            y_average = cor.y_average;
            x_average = cor.x_average;
            y_sigma = cor.y_sigma;
            y_residuals = new double[n];
            a0 = cor.a0;
            a1 = cor.a1;
            link = cor.link;
            if (link == false)
                next.Hide();

            double regression(double x)
            {
                return a0 + a1 * x;
            }
            // заполним массив остатков и выведем поле корреляции
            for (int i = 0; i < n; i++)
            {
                y_residuals[i] = y_mass[i] - regression(x_mass[i]);
                regress.Series["cor"].Points.AddXY(x_mass[i], y_mass[i]);  // поле корреляции
                residuals.Series["res"].Points.AddXY(x_mass[i], y_residuals[i]); // график остатков 
            }

            // регрессия на поле корреляции
            regress.Series["reg"].Points.AddXY(x_mass.Min(), regression(x_mass.Min()));
            regress.Series["reg"].Points.AddXY(x_mass.Max(), regression(x_mass.Max()));

            // дальше комментариев нет, там вообще ничего не понятно :(
            // (лучше не смотрите код далее, есть вероятность потерять зрение)

            double[] x_mass_copy = x_mass;
            double[] y_mass_copy = y_mass;
            cor.bubble(x_mass_copy, y_mass_copy);
            // значения кумулятивного распределения
            decimal[] i_cumul = new decimal[n];  
            for (int i = 0; i < n; i++)
                i_cumul[i] = ((decimal)i+1 - (decimal)0.5) / (decimal)n;
            // рассчитаем по функции стандартного распределения от значения кумулятивного распределения значения
            // (на входе - вероятность, на выходе - значение)
            /*double[] zt = new double[n];
            for (int i = 0; i < n; i++)
                zt[i] = standard_deviation(i_cumul[i]);
            // 
            double[] za = new double[n];
            for (int i = 0; i < n; i++)
                zt[i] = standard_deviation(i_cumul[i]);*/
            decimal[] zt = new decimal[n];
            for (int i = 0; i < n; i++)
            {
                //Console.WriteLine($"{i}");
                decimal i_zt = -3.90m;  // вышел за интервал таблицы чтобы первое число правильно инкрементировало
                decimal zt_min = 100;
                int zt_flag = 0;
                bool zt_bool = false;
                var sr = new StreamReader("SND.csv");
                while (!sr.EndOfStream)
                {
                    string[] components = sr.ReadLine().Split(';');
                    if (Decimal.Parse(components[0]) == 0.50000m)
                    {
                        zt_flag += 1;
                        if (zt_flag == 2 && zt_bool == false)
                        {
                            zt_bool = true;
                            i_zt -= 0.1m;
                        }
                    }
                    //Console.WriteLine($"zt_bool = {zt_flag} ");
                    for (int j = 0; j < components.Length; j++)
                    {
                        //Console.WriteLine($"{j} i_zt = {i_zt}   {components[j]} ");
                        if (Math.Abs(Decimal.Parse(components[j]) - i_cumul[i]) < zt_min)
                        {
                            zt[i] = i_zt;
                            zt_min = Math.Abs(Decimal.Parse(components[j]) - i_cumul[i]);
                        }
                        if (zt_flag < 2)
                            i_zt -= 0.01m;
                        else
                            i_zt += 0.01m;
                    }
                    //Console.WriteLine($"zt[{i}] = {zt[i]} ");
                    if (zt_flag < 2)
                        i_zt += 0.2m;
                }
                sr.Close();
                //Console.WriteLine($"zt[{i}] = {zt[i]} ");
            }

            // считаем za
            double[] za = new double[n];
            for (int i = 0; i < n; i++)
                za[i] = (y_mass_copy[i] - y_average) / y_sigma;

            // вывод qq plot
            for (int i = 0; i < n; i++)
            {
                //Console.Write($"{za[i]} ");
                qq_plot.Series["cor"].Points.AddXY(zt[i], za[i]);
            }
            // рассчитываем данные для тренда
            double zt_average = 0;  // x среднее
            double za_average = 0;  // y среднее
            double zt_disp = 0;  // дисперсия zt
            double za_disp = 0;  // дисперсия za
            double zt_sigma = 0;  // ср квадратич zt
            double za_sigma = 0;  // ср квадратич za
            double qq_r = 0;
            double qq_a0 = 0;
            double qq_a1 = 0;
            for (int i = 0; i < n; i++)
            {
                zt_average += Convert.ToDouble(zt[i]);
                za_average += za[i];
            }
            zt_average = zt_average / (double)n;
            za_average = za_average / (double)n;

            // рассчитываем дисперсии
            for (int i = 0; i < n; i++)
            {
                zt_disp += Math.Pow((Convert.ToDouble(zt[i]) - zt_average), 2);
                za_disp += Math.Pow((za[i] - za_average), 2);
            }
            zt_disp = zt_disp / (double)n;
            za_disp = za_disp / (double)n;

            // исправляем сигмы
            if (n > 30)
            {
                zt_sigma = Math.Sqrt(zt_disp);
                za_sigma = Math.Sqrt(za_disp);
            }
            else
            {
                zt_sigma = Math.Sqrt(zt_disp * (double)n / (double)(n - 1));
                za_sigma = Math.Sqrt(za_disp * (double)n / (double)(n - 1));
            }

            // рассчитываем корреляцию
            for (int i = 0; i < n; i++)
            {
                qq_r += (Convert.ToDouble(zt[i]) - zt_average) * (za[i] - za_average);
            }
            qq_r = qq_r / (double)((n - 1) * zt_sigma * za_sigma);
            qq_a1 = qq_r * za_sigma / zt_sigma;
            qq_a0 = za_average - zt_average * qq_a1;
            double qq_regression(double x)
            {
                return qq_a0 + qq_a1 * x;
            }
            qq_plot.Series["reg"].Points.AddXY(zt.Min(), qq_regression(Decimal.ToDouble(zt.Min())));
            qq_plot.Series["reg"].Points.AddXY(zt.Max(), qq_regression(Decimal.ToDouble(zt.Max())));
        }
        private void next_Click(object sender, EventArgs e)
        {
            DialogPolationForm dialog = new DialogPolationForm(this);
            dialog.Show();
            Hide();
        }

        protected void SetForm_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
