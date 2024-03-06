namespace Wood_Project
{
    partial class CreateSalesBilling
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.namelabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.proname = new System.Windows.Forms.ComboBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.allproductinvoice = new System.Windows.Forms.DataGridView();
            this.addquent = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.updatbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricepro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namepro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.allproductinvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addquent)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic);
            this.namelabel.Location = new System.Drawing.Point(331, 87);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(42, 24);
            this.namelabel.TabIndex = 0;
            this.namelabel.Text = "الكمية";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 27);
            this.label3.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(316, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "اسم المنتج";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // proname
            // 
            this.proname.FormattingEnabled = true;
            this.proname.Location = new System.Drawing.Point(136, 29);
            this.proname.Name = "proname";
            this.proname.Size = new System.Drawing.Size(174, 35);
            this.proname.TabIndex = 7;
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.addbtn.Font = new System.Drawing.Font("Mongolian Baiti", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addbtn.Location = new System.Drawing.Point(17, 73);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(95, 53);
            this.addbtn.TabIndex = 9;
            this.addbtn.Text = "اضافة";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // allproductinvoice
            // 
            this.allproductinvoice.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.allproductinvoice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.allproductinvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allproductinvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allproductinvoice.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.allproductinvoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allproductinvoice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.allproductinvoice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allproductinvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.allproductinvoice.ColumnHeadersHeight = 30;
            this.allproductinvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.total,
            this.pricepro,
            this.quent,
            this.namepro});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.allproductinvoice.DefaultCellStyle = dataGridViewCellStyle3;
            this.allproductinvoice.EnableHeadersVisualStyles = false;
            this.allproductinvoice.GridColor = System.Drawing.SystemColors.ControlLight;
            this.allproductinvoice.Location = new System.Drawing.Point(469, 191);
            this.allproductinvoice.Name = "allproductinvoice";
            this.allproductinvoice.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allproductinvoice.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.allproductinvoice.RowHeadersVisible = false;
            this.allproductinvoice.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.allproductinvoice.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.allproductinvoice.RowTemplate.Height = 39;
            this.allproductinvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allproductinvoice.Size = new System.Drawing.Size(596, 375);
            this.allproductinvoice.TabIndex = 10;
            this.allproductinvoice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.allproductinvoice_CellClick);
            // 
            // addquent
            // 
            this.addquent.Location = new System.Drawing.Point(196, 87);
            this.addquent.Name = "addquent";
            this.addquent.Size = new System.Drawing.Size(114, 35);
            this.addquent.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(403, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 37);
            this.label1.TabIndex = 21;
            this.label1.Text = "فاتوره مبيعات";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.proname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.addquent);
            this.groupBox1.Controls.Add(this.namelabel);
            this.groupBox1.Controls.Add(this.addbtn);
            this.groupBox1.Location = new System.Drawing.Point(683, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 150);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اضافه منتج للفاتوره";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // updatbtn
            // 
            this.updatbtn.BackColor = System.Drawing.Color.DarkCyan;
            this.updatbtn.Font = new System.Drawing.Font("Modern No. 20", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatbtn.ForeColor = System.Drawing.Color.White;
            this.updatbtn.Location = new System.Drawing.Point(90, 592);
            this.updatbtn.Name = "updatbtn";
            this.updatbtn.Size = new System.Drawing.Size(158, 54);
            this.updatbtn.TabIndex = 12;
            this.updatbtn.Text = "تعديل منتج من الفاتوره";
            this.updatbtn.UseVisualStyleBackColor = false;
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.deletebtn.Font = new System.Drawing.Font("Modern No. 20", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deletebtn.Location = new System.Drawing.Point(469, 592);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(200, 53);
            this.deletebtn.TabIndex = 11;
            this.deletebtn.Text = "حذف المنتج من الفاتوره";
            this.deletebtn.UseVisualStyleBackColor = false;
            // 
            // Clearbtn
            // 
            this.Clearbtn.BackColor = System.Drawing.Color.DarkCyan;
            this.Clearbtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbtn.ForeColor = System.Drawing.Color.White;
            this.Clearbtn.Location = new System.Drawing.Point(294, 592);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(137, 53);
            this.Clearbtn.TabIndex = 13;
            this.Clearbtn.Text = "مسح البيانات";
            this.Clearbtn.UseVisualStyleBackColor = false;
            // 
            // total
            // 
            this.total.HeaderText = "الأجمالي";
            this.total.Name = "total";
            // 
            // pricepro
            // 
            this.pricepro.HeaderText = "السعر";
            this.pricepro.Name = "pricepro";
            // 
            // quent
            // 
            this.quent.HeaderText = "الكمية";
            this.quent.Name = "quent";
            // 
            // namepro
            // 
            this.namepro.HeaderText = "اسم المنتج";
            this.namepro.Name = "namepro";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(700, 592);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 53);
            this.button1.TabIndex = 24;
            this.button1.Text = "عرض الفاتورة";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // CreateSalesBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1083, 717);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.updatbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.allproductinvoice);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreateSalesBilling";
            this.Text = "فاتوره مبيعات";
            ((System.ComponentModel.ISupportInitialize)(this.allproductinvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addquent)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox proname;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.DataGridView allproductinvoice;
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
        private System.Windows.Forms.NumericUpDown addquent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricepro;
        private System.Windows.Forms.DataGridViewTextBoxColumn quent;
        private System.Windows.Forms.DataGridViewTextBoxColumn namepro;
        private System.Windows.Forms.Button updatbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Button button1;
    }
}