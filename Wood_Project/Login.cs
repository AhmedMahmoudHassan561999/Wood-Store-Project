using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wood_Project
{
    public partial class Login : Form
    {
        private Wood_ProjectEntities context;
        public Login()
        {
            InitializeComponent();
            context = new Wood_ProjectEntities();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("هل انت متاكد من قفل الصفحه؟", "ألغاء", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
                e.Cancel = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
                textBox2.PasswordChar = '\0';

            else
                textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;

            var user = context.users.Where(u => u.Email == email && u.Password == password).FirstOrDefault();

            if (user == null)
                MessageBox.Show("Invalid email or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                //CurrentUserLogin.UserLogginID = user.UserID;
                MessageBox.Show("Login Successful", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //designForm designForm = new designForm();
                //this.Hide();
                //designForm.ShowDialog();
                //this.Close();

            }
        }
    }
}
