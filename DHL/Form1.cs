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

namespace DHL
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private int loginCount = 0;
        private void loginbtn_Click(object sender, EventArgs e)
        {
            string username = usernametxtbox.Text;
            string password = pswdtxtbox.Text;
     
            string actionDate = DateTime.Now.ToString();
            var writer = new StreamWriter("userLog.txt");
            writer.WriteLine("Date and Time | User | action | Page");
            writer.Close();

            if (username=="shah_d__" && password == "shahd1234")
            {
                
                MainScreen mainScreen = new MainScreen();
                mainScreen.Show();
                this.Hide();
            }

            else
            {
                if (loginCount == 3)
                {
                   
                    Application.Exit();
                }

                loginCount +=1;
                MessageBox.Show("Invalid credentials, wrong username or password");
                
            }
        }

        private void pswdtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernametxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
