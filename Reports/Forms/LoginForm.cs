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
            string username=Userbox.Text.Trim();
            string password=Passbox.Text;
            var db = FireStoreHelper.Database;
            DocumentReference docRef = db.Collection("UserData").Document(username);
            UserData data = docRef.GetSnapshotAsync().Result.ConvertTo<UserData>();

            if (data != null ) 
            {
              if(password==data.Password)
                {
                    Hide();
                    MainForm Mf = new MainForm();
                    Mf.ShowDialog();
                    Close();
                }else
                {
                    MessageBox.Show("Please Contact Administrator..");
                }
            }
            else
            {
                MessageBox.Show("Please Contact Administrator..");
            }
          

           
        }
        string dbpassword, dbusername;
        private UserData GetData()
        {
            string username= Userbox.Text.Trim();
            string password=Passbox.Text;
            
            return new UserData()
            {
                Username = username,
                Password = password,
                DBPassword = dbpassword,
                DBUsername = dbusername,
            };
        }
    }
}
