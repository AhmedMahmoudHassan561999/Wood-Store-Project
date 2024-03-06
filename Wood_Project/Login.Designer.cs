using System;
using System.Windows.Forms;
namespace Wood_Project
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Cancel_Btn = new Guna.UI2.WinForms.Guna2Button();
            this.textBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.RegesterNow = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic);
            this.name.Location = new System.Drawing.Point(549, 133);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(88, 24);
            this.name.TabIndex = 0;
            this.name.Text = "أسم المستخدم ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(549, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "كلمة السر";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Animated = true;
            this.button1.BorderRadius = 20;
            this.button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button1.FillColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(134, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "تسجيل الدخول";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancel_Btn
            // 
            this.Cancel_Btn.BackColor = System.Drawing.Color.White;
            this.Cancel_Btn.BorderRadius = 20;
            this.Cancel_Btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Cancel_Btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Cancel_Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Cancel_Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Cancel_Btn.FillColor = System.Drawing.Color.Black;
            this.Cancel_Btn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.Cancel_Btn.ForeColor = System.Drawing.Color.White;
            this.Cancel_Btn.Location = new System.Drawing.Point(379, 411);
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.PressedColor = System.Drawing.Color.Aquamarine;
            this.Cancel_Btn.Size = new System.Drawing.Size(216, 45);
            this.Cancel_Btn.TabIndex = 10;
            this.Cancel_Btn.Text = "إلغاء";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.BorderColor = System.Drawing.Color.Black;
            this.textBox1.BorderRadius = 15;
            this.textBox1.BorderThickness = 0;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.DefaultText = "";
            this.textBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox1.FillColor = System.Drawing.SystemColors.Menu;
            this.textBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Italic);
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox1.Location = new System.Drawing.Point(179, 124);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '\0';
            this.textBox1.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.textBox1.PlaceholderText = "ادخل الإيميل";
            this.textBox1.SelectedText = "";
            this.textBox1.Size = new System.Drawing.Size(324, 48);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Transparent;
            this.textBox2.BorderColor = System.Drawing.Color.Black;
            this.textBox2.BorderRadius = 15;
            this.textBox2.BorderThickness = 0;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.DefaultText = "";
            this.textBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox2.FillColor = System.Drawing.SystemColors.Menu;
            this.textBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Italic);
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox2.Location = new System.Drawing.Point(179, 211);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.textBox2.PlaceholderText = "ادخل كلمه السر";
            this.textBox2.SelectedText = "";
            this.textBox2.Size = new System.Drawing.Size(324, 48);
            this.textBox2.TabIndex = 12;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Location = new System.Drawing.Point(194, 286);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(121, 23);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "عرض كلمه السر";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // RegesterNow
            // 
            this.RegesterNow.Animated = true;
            this.RegesterNow.BorderRadius = 20;
            this.RegesterNow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RegesterNow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RegesterNow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RegesterNow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RegesterNow.FillColor = System.Drawing.Color.Silver;
            this.RegesterNow.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.RegesterNow.ForeColor = System.Drawing.Color.White;
            this.RegesterNow.Location = new System.Drawing.Point(287, 502);
            this.RegesterNow.Name = "RegesterNow";
            this.RegesterNow.Size = new System.Drawing.Size(216, 45);
            this.RegesterNow.TabIndex = 15;
            this.RegesterNow.Text = "إنشاء حساب جديد";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1071, 596);
            this.Controls.Add(this.RegesterNow);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Cancel_Btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label name;
        private Label label2;
        private Label label3;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Button button1;
        private Guna.UI2.WinForms.Guna2Button Cancel_Btn;
        private Guna.UI2.WinForms.Guna2TextBox textBox1;
        private Guna.UI2.WinForms.Guna2TextBox textBox2;
        private CheckBox checkBox1;
        private Guna.UI2.WinForms.Guna2Button RegesterNow;
    }
}