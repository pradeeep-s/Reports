using Google.Cloud.Firestore;
using Google.Type;
using Reports.Classes;
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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void Register_Button_Click(object sender, EventArgs e)
        {
            var db = FireStoreHelper.Database;
            var data = GetData();
            DocumentReference docref = db.Collection("UserData").Document(data.Username);
            docref.SetAsync(data);
            MessageBox.Show("Registered Succesfully");


        }
        private UserData GetData()
        {
            string username = Userbox.Text.Trim();
            string password = Security.Encrypt (Passbox.Text);
            string dbuser = DBUserbox.Text.Trim();
            string dbpwd = DBPassbox.Text;
            string date = Datebox.Value.ToString("yyyy-MM-dd");
            return new UserData()
            {
                Username = username,
                Password = password,
                DBUsername = dbuser,
                DBPassword = dbpwd,
                Date = date,
            };


        }

        private void Back_Login_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm Lf = new LoginForm();
            Lf.ShowDialog();
            Close();
        }
    }
}
