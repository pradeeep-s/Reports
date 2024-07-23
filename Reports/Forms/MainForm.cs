using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reports.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void LogOut_Button_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm Lf = new LoginForm();
            Lf.ShowDialog();
            Close();

        }
    }
}
