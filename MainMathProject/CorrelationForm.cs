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
        // задал таблицу т стьюдента чтобы не использовать csv файл с этой таблицуй
        double[,] t_mass = new double[,] {{1,12.7, 63.65, 636.61},
                                        {2,4.303, 9.925, 31.602},
                                        {3,3.182, 5.841, 12.923},
                                        {4,2.776, 4.604, 8.610},
                                        {5,2.571, 4.032, 6.869},
                                        {6,2.447, 3.707, 5.959},
                                        {7,2.365, 3.499, 5.408},
                                        {8,2.306, 3.355, 5.041},
                                        {9,2.262, 3.250, 4.781},
                                        {10,2.228, 3.169, 4.587},
                                        {11,2.201, 3.106, 4.437},
                                        {12,2.179, 3.055, 4.318},
                                        {13,2.16, 3.012, 4.221},
                                        {14,2.145, 2.977, 4.140},
                                        {15,2.131, 2.947, 4.073},
                                        {16,2.12, 2.921, 4.015},
                                        {17,2.11, 2.898, 3.965},
                                        {18,2.101, 2.878, 3.922},
                                        {19,2.093, 2.861, 3.883},
                                        {20,2.086, 2.845, 3.850},
                                        {21,2.08, 2.831, 3.819},
                                        {22,2.074, 2.819, 3.792},
                                        {23,2.069, 2.807, 3.768},
                                        {24,2.064, 2.797, 3.745},
                                        {25,2.06, 2.787, 3.725},
                                        {26,2.056, 2.779, 3.707},
                                        {27,2.052, 2.771, 3.690},
                                        {28,2.049, 2.763, 3.674},
                                        {29,2.045, 2.756, 3.659},
                                        {30,2.042, 2.750, 3.646},
                                        {31,2.04, 2.744, 3.633},
                                        {32,2.037, 2.738, 3.622},
                                        {33,2.035, 2.733, 3.611},
                                        {34,2.032, 2.728, 3.601},
                                        {35,2.03, 2.724, 3.591},
                                        {36,2.028, 2.719, 3.582},
                                        {37,2.026, 2.715, 3.574},
                                        {38,2.024, 2.712, 3.566},
                                        {39,2.023, 2.708, 3.558},
                                        {40,2.021, 2.704, 3.551},
                                        {41,2.02, 2.701, 3.544},
                                        {42,2.018, 2.698, 3.538},
                                        {43,2.017, 2.695, 3.532},
                                        {44,2.015, 2.692, 3.526},
                                        {45,2.014, 2.690, 3.520},
                                        {46,2.013, 2.687, 3.515},
                                        {47,2.012, 2.685, 3.510},
                                        {48,2.011, 2.682, 3.505},
                                        {49,2.01, 2.680, 3.500},
                                        {50,2.009, 2.678, 3.496},
                                        {51,2.008, 2.676, 3.492},
                                        {52,2.007, 2.674, 3.488},
                                        {53,2.006, 2.672, 3.484},
                                        {54,2.005, 2.670, 3.480},
                                        {55,2.004, 2.688, 3.476},
                                        {56,2.003, 2.667, 3.473},
                                        {57,2.002, 2.665, 3.470},
                                        {58,2.002, 2.663, 3.466},
                                        {59,2.001, 2.662, 3.463},
                                        {60,2, 2.660, 3.460},
                                        {61,2, 2.659, 3.457},
                                        {62,1.999, 2.657, 3.454},
                                        {63,1.998, 2.656, 3.452},
                                        {64,1.998, 2.655, 3.449},
                                        {65,1.997, 2.654, 3.447},
                                        {66,1.997, 2.652, 3.444},
                                        {67,1.996, 2.651, 3.442},
                                        {68,1.995, 2.650, 3.439},
                                        {69,1.995, 2.649, 3.437},
                                        {70,1.994, 2.648, 3.435},
                                        {71,1.994, 2.647, 3.433},
                                        {72,1.993, 2.646, 3.431},
                                        {73,1.993, 2.645, 3.429},
                                        {74,1.993, 2.644, 3.427},
                                        {75,1.992, 2.643, 3.425},
                                        {76,1.992, 2.642, 3.423},
                                        {77,1.991, 2.641, 3.422},
                                        {78,1.991, 2.640, 3.420},
                                        {79,1.99, 2.639, 3.418},
                                        {80,1.99, 2.639, 3.416},
                                        {90,1.987, 2.632, 3.402},
                                        {100,1.984, 2.626, 3.390},
                                        {110,1.982, 2.621, 3.381},
                                        {120,1.98, 2.617, 3.373},
                                        {130,1.978, 2.614, 3.367},
                                        {140,1.977, 2.611, 3.361},
                                        {150,1.976, 2.609, 3.357},
                                        {200,1.972, 2.601, 3.340},
                                        {250,1.969, 2.596, 3.330},
                                        {300,1.968, 2.592, 3.323},
                                        {350,1.967, 2.590, 3.319}};

        public double[] x_mass;
        public double[] y_mass;
        int n = 0;  // кол-во комбинаций x y
        public double x_average = 0;  // x среднее
        public double y_average = 0;  // y среднее
        double x_disp = 0;  // дисперсия x
        double y_disp = 0;  // дисперсия y
        public double x_sigma = 0;  // ср квадратич x
        public double y_sigma = 0;  // ср квадратич y
        public double r = 0;  // коэфф корреляции
        int df = 0;  // степени свободы
        double t_observ = 0;  // т-критерий наблюдаемый
        double t_table = 0;  // т-критерий табличный
        public int rel_index = 1;  // индекс т-критерия
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
        /*void smass(double[] mass)
        {
            for (int i = 0; i < mass.Length; i++)
                Console.Write($"{mass[i]} ");
            Console.WriteLine();
        }*/
        public CorrelationForm(ShowRegressForm reg)
        {
            InitializeComponent();
            x_mass = reg.x_mass;
            y_mass = reg.y_mass;
            n = x_mass.Length;
            rel_index = reg.rel_index;  // индекс в таблице критерия т стьюдента
            body();
        }

        public CorrelationForm(ReliabilityForm rel)
        {
            InitializeComponent();
            x_mass = rel.x_mass;
            y_mass = rel.y_mass;
            n = x_mass.Length;
            rel_index = rel.rel_index;  // индекс в таблице критерия т стьюдента
            body();
        }

        // тело формы
        void body()
        {
            bubble(y_mass, x_mass);
            /*Console.Write("Массив x: ");
            smass(x_mass);
            Console.Write("Массив y: ");
            smass(y_mass);*/
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

            if (n > 30)
                r = r / (double)(n * x_sigma * y_sigma);
            else
                r = r / (double)((n - 1) * x_sigma * y_sigma);

            r_label.Text = $"r = {r}";
            r2_label.Text = $"r^2 = {Math.Pow(r, 2)}";

            // рассчет степеней свободы
            df = n - 2;
            // корректировка степеней свободы, т.к. в таблице они с 80 степени идут не через 1
            if (df >= 80 && df < 150)
                df = Decimal.ToInt32(decimal.Round(decimal.Parse(df.ToString()) / 10m, 0, MidpointRounding.AwayFromZero) * 10);
            else if (df >= 150 && df <= 350)
                df = Decimal.ToInt32(decimal.Round(decimal.Parse(df.ToString()) / 50m, 0, MidpointRounding.AwayFromZero) * 50);

            // проверка гипотез
            /*var sr = new StreamReader("t.csv");
            while (!sr.EndOfStream)
            {
                string[] components = sr.ReadLine().Split(';');
                if (Int32.Parse(components[0]) == df)
                {
                    t_table = Double.Parse(components[rel_index].Trim(' '));
                    break;
                }
            }
            sr.Close();*/
            for (int i = 0; i < 91; i++)
            {
                if (t_mass[i, 0] == (double)df)
                {
                    t_table = t_mass[i, rel_index];
                    break;
                }
            }

            t_observ = (double)(r * Math.Sqrt(n - 2) / (double)(Math.Sqrt(1 - Math.Pow(r, 2))));
            if (Math.Abs(t_observ) > t_table)
            {
                link = true;
                if (rel_index == 1)
                    hyp_test.Text = "Между X и Y существует тесная связь\nс надежностью 95%";
                else if (rel_index == 2)
                    hyp_test.Text = "Между X и Y существует тесная связь\nс надежностью 99%";
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
            if (a1 >= 0)
                regress_func.Text = $"y = {a0:F6} + {a1:F6}x";
            else
                regress_func.Text = $"y = {a0:F6} - {Math.Abs(a1):F6}x";
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
