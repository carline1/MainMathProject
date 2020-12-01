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
    public partial class DataInputSelectionForm : Form
    {
        public DataInputSelectionForm()
        {
            InitializeComponent();
        }

        private void hand_input_Click(object sender, EventArgs e)
        {
            InputNForm input_n = new InputNForm();
            input_n.Show();
            Hide();
        }

        private void open_file_Click(object sender, EventArgs e)
        {
            FileHelperForm helper = new FileHelperForm();
            helper.Show();
            Hide();
        }
        protected void SetForm_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
