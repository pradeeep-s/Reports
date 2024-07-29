using Google.Cloud.Firestore;
using Reports.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reports.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_Button_Click(object sender, EventArgs e)

        {
            string username = Userbox.Text.Trim();
            string password = Passbox.Text;
            var db = FireStoreHelper.Database;
            DocumentReference docRef = db.Collection("UserData").Document(username);
            UserData data = docRef.GetSnapshotAsync().Result.ConvertTo<UserData>();

            if (data != null)
            {
                if (password == Security.Decrypt(data.Password))
                {
                    Hide();
                    MainForm Mf = new MainForm();
                    Mf.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Please Contact Administrator..");
                }
            }
            else
            {
                MessageBox.Show("Please Contact Administrator..");
            }



        }
        private void BacktoRegister_Click(object sender, EventArgs e)
        {
            Hide();
            RegisterForm Rf = new RegisterForm();
            Rf.ShowDialog();
            Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

    }
}
