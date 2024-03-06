using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wood_Project
{
    public partial class Register : Form
    {
        private Wood_ProjectEntities context;
        public Register()
        {
            InitializeComponent();
            context = new Wood_ProjectEntities();
            namealarm.Visible = false;
            emailalarm.Visible = false;
            Passalarm.Visible = false;
            idalarm.Visible = false;
        }
        string passwordpattern = @"^(?:(?=.*[a-z])(?:(?=.*[A-Z])(?=.*[\d\W])|(?=.*\W)(?=.*\d))|(?=.*\W)(?=.*[A-Z])(?=.*\d)).{8,}$";
        string emailpattern = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
        private void Register_Load(object sender, EventArgs e)
        {
           



        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (showpass.Checked)
            {
                Pass.PasswordChar = '\0';
                confpass.PasswordChar = '\0';
            }
            else
            {
                Pass.PasswordChar = '*';
                confpass.PasswordChar = '*';
            }

        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("هل انت متأكد من قفل الصفحة ", "قفل الصفحة",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question);

            e.Cancel = (result == DialogResult.No);
        }

        private void Regsterbtn_Click(object sender, EventArgs e)
        {

            var emailOrNationalIdExists =context.users.Any(u => u.Email == email.Text || u.NationalID == idnum.Text);

            if (emailOrNationalIdExists)
            {
                MessageBox.Show("Email or National Already Exists", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            if (Fname.Text == "" ||
                Lname.Text == "" ||
                !Regex.IsMatch(email.Text, emailpattern) ||
                !Regex.IsMatch(Pass.Text, passwordpattern) ||
            idnum.TextLength != 14)
            {

                if (Fname.Text == "" || Lname.Text == "")
                {
                    Fname.Text = "";
                    Lname.Text = "";
                    Fname.Focus();
                    namealarm.Visible = true;
                    emailalarm.Visible = false;
                    Passalarm.Visible = false;
                    idalarm.Visible = false;
                }
                if (!Regex.IsMatch(email.Text, emailpattern))
                {
                    email.Text = "";
                    namealarm.Visible = false;
                    emailalarm.Visible = true;
                    Passalarm.Visible = false;
                    idalarm.Visible = false;

                }
                if (!Regex.IsMatch(Pass.Text, passwordpattern) &&
                      Pass.Text != confpass.Text)
                {
                    Pass.Text = "";
                    confpass.Text = "";
                    Pass.Focus();
                    namealarm.Visible = false;
                    emailalarm.Visible = false;
                    Passalarm.Visible = true;
                    idalarm.Visible = false;
                }
                if (idnum.TextLength != 14)
                {
                    idnum.Text = "";
                    idnum.Focus();
                    namealarm.Visible = false;
                    emailalarm.Visible = false;
                    Passalarm.Visible = false;
                    idalarm.Visible = true;
                }



                RegFaildLbl.Visible = true;

            }
            else
            {

                user newUser = new user()
                {
                    FName = Fname.Text,
                    LName = Lname.Text,
                    Email = email.Text,
                    Password = Pass.Text,
                    NationalID = idnum.Text,
                    AccountStatus = true

                };

                context.users.Add(newUser);
                context.SaveChanges();

                var AddTest = context.users.Select(s => s.UserID).OrderByDescending(s => s).FirstOrDefault();
                //CurrentUserLogin.UserLogginID = AddTest;

                namealarm.Visible = false;
                emailalarm.Visible = false;
                Passalarm.Visible = false;
                idalarm.Visible = false;
                Fname.Text = "";
                Lname.Text = "";
                email.Text = "";
                Pass.Text = "";
                confpass.Text = "";
                idnum.Text = "";

                MessageBox.Show("sucess Data", "Regestration Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //AddUserToPlayerTable();
                //this.Hide();
                ////Login_Form login_ = new Login_Form();
                ////login_.ShowDialog();
                //this.Close();

            }
        }

        private void Signinbtn_Click(object sender, EventArgs e)
        {
            Login login_Form = new Login();
            login_Form.ShowDialog();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            Fname.Text = "";
            Lname.Text = "";
            email.Text = "";
            Pass.Text = "";
            confpass.Text = "";
            idnum.Text = "";
            namealarm.Visible = false;
            emailalarm.Visible = false;
            Passalarm.Visible = false;
            idalarm.Visible = false;
        }
    }



}
