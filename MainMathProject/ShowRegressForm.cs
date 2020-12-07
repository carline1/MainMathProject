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
        public double r;  
        decimal[,] snd_mass = new decimal[,] {{0.00005m,0.00005m,0.00004m,0.00004m,0.00004m,0.00004m,0.00004m,0.00004m,0.00003m,0.00003m},
                                            {0.00007m,0.00007m,0.00007m,0.00006m,0.00006m,0.00006m,0.00006m,0.00005m,0.00005m,0.00005m},
                                            {0.00011m,0.00010m,0.00010m,0.00010m,0.00009m,0.00009m,0.00008m,0.00008m,0.00008m,0.00008m},
                                            {0.00016m,0.00015m,0.00015m,0.00014m,0.00014m,0.00013m,0.00013m,0.00012m,0.00012m,0.00011m},
                                            {0.00023m,0.00022m,0.00022m,0.00021m,0.00020m,0.00019m,0.00019m,0.00018m,0.00017m,0.00017m},
                                            {0.00034m,0.00032m,0.00031m,0.00030m,0.00029m,0.00028m,0.00027m,0.00026m,0.00025m,0.00024m},
                                            {0.00048m,0.00047m,0.00045m,0.00043m,0.00042m,0.00040m,0.00039m,0.00038m,0.00036m,0.00035m},
                                            {0.00069m,0.00066m,0.00064m,0.00062m,0.00060m,0.00058m,0.00056m,0.00054m,0.00052m,0.00050m},
                                            {0.00097m,0.00094m,0.00090m,0.00087m,0.00084m,0.00082m,0.00079m,0.00076m,0.00074m,0.00071m},
                                            {0.00135m,0.00131m,0.00126m,0.00122m,0.00118m,0.00114m,0.00111m,0.00107m,0.00104m,0.00100m},
                                            {0.00187m,0.00181m,0.00175m,0.00169m,0.00164m,0.00159m,0.00154m,0.00149m,0.00144m,0.00139m},
                                            {0.00256m,0.00248m,0.00240m,0.00233m,0.00226m,0.00219m,0.00212m,0.00205m,0.00199m,0.00193m},
                                            {0.00347m,0.00336m,0.00326m,0.00317m,0.00307m,0.00298m,0.00289m,0.00280m,0.00272m,0.00264m},
                                            {0.00466m,0.00453m,0.00440m,0.00427m,0.00415m,0.00402m,0.00391m,0.00379m,0.00368m,0.00357m},
                                            {0.00621m,0.00604m,0.00587m,0.00570m,0.00554m,0.00539m,0.00523m,0.00508m,0.00494m,0.00480m},
                                            {0.00820m,0.00798m,0.00776m,0.00755m,0.00734m,0.00714m,0.00695m,0.00676m,0.00657m,0.00639m},
                                            {0.01072m,0.01044m,0.01017m,0.00990m,0.00964m,0.00939m,0.00914m,0.00889m,0.00866m,0.00842m},
                                            {0.01390m,0.01355m,0.01321m,0.01287m,0.01255m,0.01222m,0.01191m,0.01160m,0.01130m,0.01101m},
                                            {0.01786m,0.01743m,0.01700m,0.01659m,0.01618m,0.01578m,0.01539m,0.01500m,0.01463m,0.01426m},
                                            {0.02275m,0.02222m,0.02169m,0.02118m,0.02068m,0.02018m,0.01970m,0.01923m,0.01876m,0.01831m},
                                            {0.02872m,0.02807m,0.02743m,0.02680m,0.02619m,0.02559m,0.02500m,0.02442m,0.02385m,0.02330m},
                                            {0.03593m,0.03515m,0.03438m,0.03362m,0.03288m,0.03216m,0.03144m,0.03074m,0.03005m,0.02938m},
                                            {0.04457m,0.04363m,0.04272m,0.04182m,0.04093m,0.04006m,0.03920m,0.03836m,0.03754m,0.03673m},
                                            {0.05480m,0.05370m,0.05262m,0.05155m,0.05050m,0.04947m,0.04846m,0.04746m,0.04648m,0.04551m},
                                            {0.06681m,0.06552m,0.06426m,0.06301m,0.06178m,0.06057m,0.05938m,0.05821m,0.05705m,0.05592m},
                                            {0.08076m,0.07927m,0.07780m,0.07636m,0.07493m,0.07353m,0.07215m,0.07078m,0.06944m,0.06811m},
                                            {0.09680m,0.09510m,0.09342m,0.09176m,0.09012m,0.08851m,0.08691m,0.08534m,0.08379m,0.08226m},
                                            {0.11507m,0.11314m,0.11123m,0.10935m,0.10749m,0.10565m,0.10383m,0.10204m,0.10027m,0.09853m},
                                            {0.13567m,0.13350m,0.13136m,0.12924m,0.12714m,0.12507m,0.12302m,0.12100m,0.11900m,0.11702m},
                                            {0.15866m,0.15625m,0.15386m,0.15151m,0.14917m,0.14686m,0.14457m,0.14231m,0.14007m,0.13786m},
                                            {0.18406m,0.18141m,0.17879m,0.17619m,0.17361m,0.17106m,0.16853m,0.16602m,0.16354m,0.16109m},
                                            {0.21186m,0.20897m,0.20611m,0.20327m,0.20045m,0.19766m,0.19489m,0.19215m,0.18943m,0.18673m},
                                            {0.24196m,0.23885m,0.23576m,0.23270m,0.22965m,0.22663m,0.22363m,0.22065m,0.21770m,0.21476m},
                                            {0.27425m,0.27093m,0.26763m,0.26435m,0.26109m,0.25785m,0.25463m,0.25143m,0.24825m,0.24510m},
                                            {0.30854m,0.30503m,0.30153m,0.29806m,0.29460m,0.29116m,0.28774m,0.28434m,0.28096m,0.27760m},
                                            {0.34458m,0.34090m,0.33724m,0.33360m,0.32997m,0.32636m,0.32276m,0.31918m,0.31561m,0.31207m},
                                            {0.38209m,0.37828m,0.37448m,0.37070m,0.36693m,0.36317m,0.35942m,0.35569m,0.35197m,0.34827m},
                                            {0.42074m,0.41683m,0.41294m,0.40905m,0.40517m,0.40129m,0.39743m,0.39358m,0.38974m,0.38591m},
                                            {0.46017m,0.45620m,0.45224m,0.44828m,0.44433m,0.44038m,0.43644m,0.43251m,0.42858m,0.42465m},
                                            {0.50000m,0.49601m,0.49202m,0.48803m,0.48405m,0.48006m,0.47608m,0.47210m,0.46812m,0.46414m},
                                            {0.50000m,0.50399m,0.50798m,0.51197m,0.51595m,0.51994m,0.52392m,0.52790m,0.53188m,0.53586m},
                                            {0.53983m,0.54380m,0.54776m,0.55172m,0.55567m,0.55962m,0.56356m,0.56749m,0.57142m,0.57535m},
                                            {0.57926m,0.58317m,0.58706m,0.59095m,0.59483m,0.59871m,0.60257m,0.60642m,0.61026m,0.61409m},
                                            {0.61791m,0.62172m,0.62552m,0.62930m,0.63307m,0.63683m,0.64058m,0.64431m,0.64803m,0.65173m},
                                            {0.65542m,0.65910m,0.66276m,0.66640m,0.67003m,0.67364m,0.67724m,0.68082m,0.68439m,0.68793m},
                                            {0.69146m,0.69497m,0.69847m,0.70194m,0.70540m,0.70884m,0.71226m,0.71566m,0.71904m,0.72240m},
                                            {0.72575m,0.72907m,0.73237m,0.73565m,0.73891m,0.74215m,0.74537m,0.74857m,0.75175m,0.75490m},
                                            {0.75804m,0.76115m,0.76424m,0.76730m,0.77035m,0.77337m,0.77637m,0.77935m,0.78230m,0.78524m},
                                            {0.78814m,0.79103m,0.79389m,0.79673m,0.79955m,0.80234m,0.80511m,0.80785m,0.81057m,0.81327m},
                                            {0.81594m,0.81859m,0.82121m,0.82381m,0.82639m,0.82894m,0.83147m,0.83398m,0.83646m,0.83891m},
                                            {0.84134m,0.84375m,0.84614m,0.84849m,0.85083m,0.85314m,0.85543m,0.85769m,0.85993m,0.86214m},
                                            {0.86433m,0.86650m,0.86864m,0.87076m,0.87286m,0.87493m,0.87698m,0.87900m,0.88100m,0.88298m},
                                            {0.88493m,0.88686m,0.88877m,0.89065m,0.89251m,0.89435m,0.89617m,0.89796m,0.89973m,0.90147m},
                                            {0.90320m,0.90490m,0.90658m,0.90824m,0.90988m,0.91149m,0.91309m,0.91466m,0.91621m,0.91774m},
                                            {0.91924m,0.92073m,0.92220m,0.92364m,0.92507m,0.92647m,0.92785m,0.92922m,0.93056m,0.93189m},
                                            {0.93319m,0.93448m,0.93574m,0.93699m,0.93822m,0.93943m,0.94062m,0.94179m,0.94295m,0.94408m},
                                            {0.94520m,0.94630m,0.94738m,0.94845m,0.94950m,0.95053m,0.95154m,0.95254m,0.95352m,0.95449m},
                                            {0.95543m,0.95637m,0.95728m,0.95818m,0.95907m,0.95994m,0.96080m,0.96164m,0.96246m,0.96327m},
                                            {0.96407m,0.96485m,0.96562m,0.96638m,0.96712m,0.96784m,0.96856m,0.96926m,0.96995m,0.97062m},
                                            {0.97128m,0.97193m,0.97257m,0.97320m,0.97381m,0.97441m,0.97500m,0.97558m,0.97615m,0.97670m},
                                            {0.97725m,0.97778m,0.97831m,0.97882m,0.97932m,0.97982m,0.98030m,0.98077m,0.98124m,0.98169m},
                                            {0.98214m,0.98257m,0.98300m,0.98341m,0.98382m,0.98422m,0.98461m,0.98500m,0.98537m,0.98574m},
                                            {0.98610m,0.98645m,0.98679m,0.98713m,0.98745m,0.98778m,0.98809m,0.98840m,0.98870m,0.98899m},
                                            {0.98928m,0.98956m,0.98983m,0.99010m,0.99036m,0.99061m,0.99086m,0.99111m,0.99134m,0.99158m},
                                            {0.99180m,0.99202m,0.99224m,0.99245m,0.99266m,0.99286m,0.99305m,0.99324m,0.99343m,0.99361m},
                                            {0.99379m,0.99396m,0.99413m,0.99430m,0.99446m,0.99461m,0.99477m,0.99492m,0.99506m,0.99520m},
                                            {0.99534m,0.99547m,0.99560m,0.99573m,0.99585m,0.99598m,0.99609m,0.99621m,0.99632m,0.99643m},
                                            {0.99653m,0.99664m,0.99674m,0.99683m,0.99693m,0.99702m,0.99711m,0.99720m,0.99728m,0.99736m},
                                            {0.99744m,0.99752m,0.99760m,0.99767m,0.99774m,0.99781m,0.99788m,0.99795m,0.99801m,0.99807m},
                                            {0.99813m,0.99819m,0.99825m,0.99831m,0.99836m,0.99841m,0.99846m,0.99851m,0.99856m,0.99861m},
                                            {0.99865m,0.99869m,0.99874m,0.99878m,0.99882m,0.99886m,0.99889m,0.99893m,0.99896m,0.99900m},
                                            {0.99903m,0.99906m,0.99910m,0.99913m,0.99916m,0.99918m,0.99921m,0.99924m,0.99926m,0.99929m},
                                            {0.99931m,0.99934m,0.99936m,0.99938m,0.99940m,0.99942m,0.99944m,0.99946m,0.99948m,0.99950m},
                                            {0.99952m,0.99953m,0.99955m,0.99957m,0.99958m,0.99960m,0.99961m,0.99962m,0.99964m,0.99965m},
                                            {0.99966m,0.99968m,0.99969m,0.99970m,0.99971m,0.99972m,0.99973m,0.99974m,0.99975m,0.99976m},
                                            {0.99977m,0.99978m,0.99978m,0.99979m,0.99980m,0.99981m,0.99981m,0.99982m,0.99983m,0.99983m},
                                            {0.99984m,0.99985m,0.99985m,0.99986m,0.99986m,0.99987m,0.99987m,0.99988m,0.99988m,0.99989m},
                                            {0.99989m,0.99990m,0.99990m,0.99990m,0.99991m,0.99991m,0.99992m,0.99992m,0.99992m,0.99992m},
                                            {0.99993m,0.99993m,0.99993m,0.99994m,0.99994m,0.99994m,0.99994m,0.99995m,0.99995m,0.99995m},
                                            {0.99995m,0.99995m,0.99996m,0.99996m,0.99996m,0.99996m,0.99996m,0.99996m,0.99997m,0.99997m}};

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
            r = pol.r;
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
            r = cor.r;
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
                residuals.Series["res"].Points.AddXY(regression(x_mass[i]), y_residuals[i]); // график остатков 
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

            // Вычисление при помощи файл
            /*decimal[] zt = new decimal[n];
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
            }*/

            // Вычисление без помощи файл
            decimal[] zt = new decimal[n];
            for (int i = 0; i < n; i++)
            {
                decimal i_zt = -3.90m;  // вышел за интервал таблицы чтобы первое число правильно инкрементировало
                decimal zt_min = 100;
                int zt_flag = 0;
                bool zt_bool = false;
                for (int str = 0; str < 80; str++)
                {
                    if (snd_mass[str, 0] == 0.50000m)
                    {
                        zt_flag += 1;
                        if (zt_flag == 2 && zt_bool == false)
                        {
                            zt_bool = true;
                            i_zt -= 0.1m;
                        }
                    }
                    for (int j = 0; j < 10; j++)
                    {
                        if (Math.Abs(snd_mass[str, j] - i_cumul[i]) < zt_min)
                        {
                            zt[i] = i_zt;
                            zt_min = Math.Abs(snd_mass[str, j] - i_cumul[i]);
                        }
                        if (zt_flag < 2)
                            i_zt -= 0.01m;
                        else
                            i_zt += 0.01m;
                    }
                    if (zt_flag < 2)
                        i_zt += 0.2m;
                }
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
