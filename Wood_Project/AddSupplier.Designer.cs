namespace Wood_Project
{
    partial class AddSupplier
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.namelabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.namesupp = new System.Windows.Forms.TextBox();
            this.phonenum = new System.Windows.Forms.TextBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.updatbtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.namecomp = new System.Windows.Forms.TextBox();
            this.allsuppliers = new System.Windows.Forms.DataGridView();
            this.quent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namepro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.notes = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.allsuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic);
            this.namelabel.Location = new System.Drawing.Point(800, 34);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(75, 24);
            this.namelabel.TabIndex = 0;
            this.namelabel.Text = ":اسم المورد";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(800, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = ": اسم الشركة ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(489, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = ":رقم التلفون";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(489, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = ":العنوان";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(255, 105);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(201, 31);
            this.address.TabIndex = 5;
            // 
            // namesupp
            // 
            this.namesupp.Location = new System.Drawing.Point(613, 30);
            this.namesupp.Name = "namesupp";
            this.namesupp.Size = new System.Drawing.Size(174, 31);
            this.namesupp.TabIndex = 6;
            // 
            // phonenum
            // 
            this.phonenum.Location = new System.Drawing.Point(255, 30);
            this.phonenum.Name = "phonenum";
            this.phonenum.Size = new System.Drawing.Size(215, 31);
            this.phonenum.TabIndex = 8;
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.addbtn.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic);
            this.addbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addbtn.Location = new System.Drawing.Point(61, 189);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(212, 49);
            this.addbtn.TabIndex = 9;
            this.addbtn.Text = "إضافه مورد جديد";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.deletebtn.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic);
            this.deletebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deletebtn.Location = new System.Drawing.Point(297, 189);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(224, 49);
            this.deletebtn.TabIndex = 11;
            this.deletebtn.Text = "حذف مورد سابق";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // updatbtn
            // 
            this.updatbtn.BackColor = System.Drawing.Color.DarkCyan;
            this.updatbtn.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic);
            this.updatbtn.ForeColor = System.Drawing.Color.White;
            this.updatbtn.Location = new System.Drawing.Point(61, 276);
            this.updatbtn.Name = "updatbtn";
            this.updatbtn.Size = new System.Drawing.Size(212, 49);
            this.updatbtn.TabIndex = 12;
            this.updatbtn.Text = "تعديل بيانات مورد";
            this.updatbtn.UseVisualStyleBackColor = false;
            this.updatbtn.Click += new System.EventHandler(this.updatbtn_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.BackColor = System.Drawing.Color.DarkCyan;
            this.Clearbtn.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic);
            this.Clearbtn.ForeColor = System.Drawing.Color.White;
            this.Clearbtn.Location = new System.Drawing.Point(297, 276);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(224, 49);
            this.Clearbtn.TabIndex = 13;
            this.Clearbtn.Text = "حذف البيانات";
            this.Clearbtn.UseVisualStyleBackColor = false;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // namecomp
            // 
            this.namecomp.Location = new System.Drawing.Point(613, 105);
            this.namecomp.Name = "namecomp";
            this.namecomp.Size = new System.Drawing.Size(174, 31);
            this.namecomp.TabIndex = 14;
            // 
            // allsuppliers
            // 
            this.allsuppliers.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.allsuppliers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.allsuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allsuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allsuppliers.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.allsuppliers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allsuppliers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.allsuppliers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allsuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.allsuppliers.ColumnHeadersHeight = 30;
            this.allsuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quent,
            this.type,
            this.type2,
            this.type3,
            this.namepro});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.allsuppliers.DefaultCellStyle = dataGridViewCellStyle8;
            this.allsuppliers.EnableHeadersVisualStyles = false;
            this.allsuppliers.GridColor = System.Drawing.SystemColors.ControlLight;
            this.allsuppliers.Location = new System.Drawing.Point(37, 357);
            this.allsuppliers.Name = "allsuppliers";
            this.allsuppliers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allsuppliers.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.allsuppliers.RowHeadersVisible = false;
            this.allsuppliers.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.allsuppliers.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.allsuppliers.RowTemplate.Height = 39;
            this.allsuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allsuppliers.Size = new System.Drawing.Size(814, 309);
            this.allsuppliers.TabIndex = 19;
            this.allsuppliers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.allsuppliers_CellClick);
            // 
            // quent
            // 
            this.quent.HeaderText = "الملاحظات";
            this.quent.Name = "quent";
            // 
            // type
            // 
            this.type.HeaderText = "العنوان";
            this.type.Name = "type";
            // 
            // type2
            // 
            this.type2.HeaderText = "رقم التفلون";
            this.type2.Name = "type2";
            // 
            // type3
            // 
            this.type3.HeaderText = "اسم الشركة";
            this.type3.Name = "type3";
            // 
            // namepro
            // 
            this.namepro.HeaderText = "اسم المورد";
            this.namepro.Name = "namepro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(788, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = ": الملاحظات";
            // 
            // notes
            // 
            this.notes.Location = new System.Drawing.Point(613, 168);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(169, 157);
            this.notes.TabIndex = 21;
            this.notes.Text = "";
            // 
            // AddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(977, 753);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.allsuppliers);
            this.Controls.Add(this.namecomp);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.updatbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.phonenum);
            this.Controls.Add(this.namesupp);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.namelabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddSupplier";
            this.Text = "اضاافه منتج جديد ";
            ((System.ComponentModel.ISupportInitialize)(this.allsuppliers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox namesupp;
        private System.Windows.Forms.TextBox phonenum;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button updatbtn;
        private System.Windows.Forms.Button Clearbtn;
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
        private System.Windows.Forms.TextBox namecomp;
        private System.Windows.Forms.DataGridView allsuppliers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn quent;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn type2;
        private System.Windows.Forms.DataGridViewTextBoxColumn type3;
        private System.Windows.Forms.DataGridViewTextBoxColumn namepro;
    }
}