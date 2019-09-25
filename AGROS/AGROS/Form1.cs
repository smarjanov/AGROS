using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGROS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            //ConnectToDB.FindUser();
            string userName;
            string password;

            userName = userNameTxt.Text;
            password = passwordTxt.Text;

            if(userName == "korisnik" && password == "korisnik")
            {
                MessageBox.Show("Korisnik se uspješno logirao u sustav!");
                AGROS_MAIN am = new AGROS_MAIN();
                am.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Neispravni korisnički podaci!");
            }


        }
    }
}
