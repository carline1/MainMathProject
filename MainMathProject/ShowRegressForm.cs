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
        public double y_average;
        public double x_average;
        public double y_sigma;
        public double a0 = 0;
        public double a1 = 0;
        int n = 0;
        double[] y_residuals;  // остатки
        public bool link;
        public int rel_index;

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

        public ShowRegressForm(PolationForm pol)
        {
            InitializeComponent();
            x_mass = pol.x_mass;
            y_mass = pol.y_mass;
            n = x_mass.Length;
            y_average = pol.y_average;
            x_average = pol.x_average;
            y_sigma = pol.y_sigma;
            y_residuals = new double[n];
            a0 = pol.a0;
            a1 = pol.a1;
            link = pol.link;
            rel_index = pol.rel_index;
            if (link == false)
                next.Hide();
            body();
        }

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
            rel_index = cor.rel_index;
            if (link == false)
                next.Hide();
            body();
        }

        void body()
        {
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

            double[] x_mass_copy = new double[n];
            Array.Copy(x_mass, x_mass_copy, n);
            //double[] y_mass_copy = y_mass;
            bubble(x_mass_copy, y_residuals);
            // значения кумулятивного распределения
            decimal[] i_cumul = new decimal[n];
            for (int i = 0; i < n; i++)
                i_cumul[i] = ((decimal)i + 1 - (decimal)0.5) / (decimal)n;
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
            double y_res_average = 0;
            double y_res_disp = 0;
            double y_res_sigma = 0;
            for (int i = 0; i < n; i++)
            {
                y_res_average += y_residuals[i];
            }
            y_res_average = y_res_average / (double)n;
            for (int i = 0; i < n; i++)
            {
                y_res_disp += Math.Pow((y_residuals[i] - y_res_average), 2);
            }
            y_res_disp = y_res_disp / (double)n;
            if (n > 30)
            {
                y_res_sigma = Math.Sqrt(y_res_disp);
            }
            else
            {
                y_res_sigma = Math.Sqrt(y_res_disp * (double)n / (double)(n - 1));
            }
            double[] za = new double[n];
            for (int i = 0; i < n; i++)
                za[i] = (y_residuals[i] - y_res_average) / y_res_sigma;

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

            // Гистограмма остатков
            /*int left_border = Convert.ToInt32(Math.Floor(y_residuals.Min()));
            int right_border = Convert.ToInt32(Math.Ceiling(y_residuals.Max()));
            int range = right_border - left_border;  // длина гистограммы от левой границы до правой
            double section = (double)range / (double)8;  // ширина столбца
            int[] hit = new int[8];
            double cur_section = left_border;*/
            // https://intellect.icu/poligon-i-gistogramma-primery-postroeniya-4542
            int m = (int)Math.Round(1 + 3.322 * Math.Log10(n), MidpointRounding.AwayFromZero);  // кол-во столбцов
            double section = (y_residuals.Max() - y_residuals.Min()) / (double)m;  // ширина столбца
            double left_border = y_residuals.Min() - section / 2;
            m += 1;  // это зачем-то нужно
            //double right_border = y_residuals.Max();
            int[] hit = new int[m];  // кол-во попаданий в интервал = ширине столбца
            double cur_section = left_border;
            /*for (int i = 0; i < n; i++)
                Console.Write($"{y_residuals[i]}");
            Console.Write($"left {left_border} right {right_border}");*/
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    //Console.Write($"{y_residuals[j]} >= {cur_section} && {y_residuals[j]} < {cur_section + section}  ");
                    if (y_residuals[j] >= cur_section && y_residuals[j] < cur_section + section)
                        hit[i]++;
                    //Console.WriteLine($"hit[{i}] = {hit[i]}");
                }
                cur_section += section;
            }
            cur_section = left_border;
            double test = 0;
            for (int i = 0; i < m; i++)
            {
                //Console.Write(hit[i]);
                gist_residuals.Series["col"].Points.AddXY(cur_section + (section / (double)2), (double)hit[i] / (double)n / section);
                //Console.WriteLine($" cur = {cur_section}");
                cur_section += section;
                test += (double)hit[i] / (double)n;
            }
            //Console.WriteLine($"section = {section}");
            //Console.WriteLine($"test = {test}");
            double norm_rasp_res(double x)
            {
                return (1 / (y_res_sigma * Math.Sqrt(2 * Math.PI)) * Math.Exp(-(Math.Pow(x - y_res_average, 2) / (2 * Math.Pow(y_res_sigma, 2)))));
            }
            cur_section = left_border;
            /*for (int i = 0; i < m; i++)
            {
                gist_residuals.Series["normal"].Points.AddXY(cur_section + (section / (double)2), norm_rasp_res(cur_section + (section / (double)2)));
                cur_section += section;
            } */

            for (int i = 0; i < m * 2 + 1; i++)
            {
                gist_residuals.Series["normal"].Points.AddXY(cur_section, norm_rasp_res(cur_section));
                cur_section += (section / (double)2);
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            DialogPolationForm dialog = new DialogPolationForm(this);
            dialog.Show();
            Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
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
