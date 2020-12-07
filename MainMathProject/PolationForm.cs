﻿using System;
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
        public double a0;
        public double a1;
        public int rel_index;
        public double[] x_mass;
        public double[] y_mass;
        public double x_average;
        public double y_average;
        public double y_sigma;
        public bool link;
        int n;
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
            y_average = dialog.y_average;
            y_average = dialog.y_average;
            y_sigma = dialog.y_sigma;
            link = dialog.link;
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
                    pol_value.Text = $"[{left_border:F4};{right_border:F4}] с надежностью 99%";
            }
        }

        private void back_Click(object sender, EventArgs e)
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
