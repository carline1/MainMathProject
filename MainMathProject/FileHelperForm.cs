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
    public partial class FileHelperForm : Form
    {
        public FileHelperForm()
        {
            InitializeComponent();
        }
        /*void smass(double[,] mass, int len)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < len; j++)
                    Console.Write($"{mass[i, j]} ");
                Console.WriteLine();
            } 
        }*/

        public double[] x_mass;
        public double[] y_mass;

        private void open_file_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //openFileDialog.InitialDirectory = ".\\";
                openFileDialog.Filter = "txt files (*.csv)|*.csv|All files (*.*)|*.*";
                //openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            Console.WriteLine(filePath);

            try
            {
                var sr = new StreamReader(filePath);
                string[] components = sr.ReadLine().Split(';');
                sr.Close();
                sr = new StreamReader(filePath);
                int n = components.Length;
                double[,] xy_mass = new double[2, n];
                x_mass = new double[n];
                y_mass = new double[n];
                int i = 0;
                while (!sr.EndOfStream)
                {
                    try
                    {
                        components = sr.ReadLine().Split(';');
                        for (int j = 0; j < n; j++)
                        {
                            xy_mass[i, j] = Double.Parse(components[j].Trim(' ').Replace('.', ','));
                        }
                        i++;
                    }
                    catch (Exception exp)
                    {
                        DialogResult result = MessageBox.Show($"Ошибка чтения файла\n{exp.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        if (result == DialogResult.OK)
                        {
                            SetForm_Closed(sender, e);
                            break;
                        }
                    }
                }
                for (i = 0; i < n; i++)
                {
                    x_mass[i] = xy_mass[0, i];
                    y_mass[i] = xy_mass[1, i];
                }
                ReliabilityForm rel = new ReliabilityForm(this);
                rel.Show();
                Hide();
                //smass(xy_mass, n);
            }
            catch (Exception exp)
            {
                DialogResult result = MessageBox.Show($"Ошибка чтения файла\n{exp.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
