namespace Wood_Project
{
    partial class AddProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.namelabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.updatbtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.allproducts = new System.Windows.Forms.DataGridView();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricepro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namepro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quentity = new System.Windows.Forms.NumericUpDown();
            this.price = new System.Windows.Forms.NumericUpDown();
            this.type1 = new System.Windows.Forms.ComboBox();
            this.type_3 = new System.Windows.Forms.ComboBox();
            this.type_2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.allproducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quentity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
            this.SuspendLayout();
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic);
            this.namelabel.Location = new System.Drawing.Point(833, 19);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(66, 24);
            this.namelabel.TabIndex = 0;
            this.namelabel.Text = "اسم المنتج";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(545, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "السعر";
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
            this.label4.Location = new System.Drawing.Point(833, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "النوع1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(545, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "النوع2";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(610, 24);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(215, 31);
            this.name.TabIndex = 5;
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.addbtn.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic);
            this.addbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addbtn.Location = new System.Drawing.Point(525, 172);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(212, 49);
            this.addbtn.TabIndex = 9;
            this.addbtn.Text = "اضافه منتج جديد";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.deletebtn.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic);
            this.deletebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deletebtn.Location = new System.Drawing.Point(235, 252);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(212, 49);
            this.deletebtn.TabIndex = 11;
            this.deletebtn.Text = "حذف المنتج";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // updatbtn
            // 
            this.updatbtn.BackColor = System.Drawing.Color.DarkCyan;
            this.updatbtn.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic);
            this.updatbtn.ForeColor = System.Drawing.Color.White;
            this.updatbtn.Location = new System.Drawing.Point(235, 172);
            this.updatbtn.Name = "updatbtn";
            this.updatbtn.Size = new System.Drawing.Size(212, 49);
            this.updatbtn.TabIndex = 12;
            this.updatbtn.Text = "تعديل منتج جديد";
            this.updatbtn.UseVisualStyleBackColor = false;
            this.updatbtn.Click += new System.EventHandler(this.updatbtn_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.BackColor = System.Drawing.Color.DarkCyan;
            this.Clearbtn.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic);
            this.Clearbtn.ForeColor = System.Drawing.Color.White;
            this.Clearbtn.Location = new System.Drawing.Point(525, 252);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(212, 49);
            this.Clearbtn.TabIndex = 13;
            this.Clearbtn.Text = "حذف البيانات";
            this.Clearbtn.UseVisualStyleBackColor = false;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(271, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "النوع3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic);
            this.label6.Location = new System.Drawing.Point(271, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "الكمية";
            // 
            // allproducts
            // 
            this.allproducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            this.allproducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.allproducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allproducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allproducts.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.allproducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allproducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.allproducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allproducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.allproducts.ColumnHeadersHeight = 30;
            this.allproducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.total,
            this.pricepro,
            this.quent,
            this.type,
            this.type2,
            this.type3,
            this.namepro});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.allproducts.DefaultCellStyle = dataGridViewCellStyle13;
            this.allproducts.EnableHeadersVisualStyles = false;
            this.allproducts.GridColor = System.Drawing.SystemColors.ControlLight;
            this.allproducts.Location = new System.Drawing.Point(24, 409);
            this.allproducts.Name = "allproducts";
            this.allproducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allproducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.allproducts.RowHeadersVisible = false;
            this.allproducts.RowHeadersWidth = 51;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.allproducts.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.allproducts.RowTemplate.Height = 39;
            this.allproducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allproducts.Size = new System.Drawing.Size(875, 309);
            this.allproducts.TabIndex = 18;
            this.allproducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.allproducts_CellClick);
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
            // type
            // 
            this.type.HeaderText = "النوع3";
            this.type.Name = "type";
            // 
            // type2
            // 
            this.type2.HeaderText = "النوع2";
            this.type2.Name = "type2";
            // 
            // type3
            // 
            this.type3.HeaderText = "النوع1";
            this.type3.Name = "type3";
            // 
            // namepro
            // 
            this.namepro.HeaderText = "اسم المنتج";
            this.namepro.Name = "namepro";
            // 
            // quentity
            // 
            this.quentity.Location = new System.Drawing.Point(90, 17);
            this.quentity.Name = "quentity";
            this.quentity.Size = new System.Drawing.Size(150, 31);
            this.quentity.TabIndex = 19;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(355, 25);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(174, 31);
            this.price.TabIndex = 21;
            // 
            // type1
            // 
            this.type1.FormattingEnabled = true;
            this.type1.Items.AddRange(new object[] {
            "سادة",
            "قشرة"});
            this.type1.Location = new System.Drawing.Point(608, 77);
            this.type1.Name = "type1";
            this.type1.Size = new System.Drawing.Size(217, 33);
            this.type1.TabIndex = 22;
            // 
            // type_3
            // 
            this.type_3.FormattingEnabled = true;
            this.type_3.Items.AddRange(new object[] {
            "ربطة",
            "قطع"});
            this.type_3.Location = new System.Drawing.Point(90, 85);
            this.type_3.Name = "type_3";
            this.type_3.Size = new System.Drawing.Size(150, 33);
            this.type_3.TabIndex = 23;
            // 
            // type_2
            // 
            this.type_2.FormattingEnabled = true;
            this.type_2.Items.AddRange(new object[] {
            "إم دي أف(MDF)",
            "أبلكاش"});
            this.type_2.Location = new System.Drawing.Point(355, 85);
            this.type_2.Name = "type_2";
            this.type_2.Size = new System.Drawing.Size(174, 33);
            this.type_2.TabIndex = 24;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(977, 753);
            this.Controls.Add(this.type_2);
            this.Controls.Add(this.type_3);
            this.Controls.Add(this.type1);
            this.Controls.Add(this.price);
            this.Controls.Add(this.quentity);
            this.Controls.Add(this.allproducts);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.updatbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.namelabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddProduct";
            this.Text = "اضاافه منتج جديد ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddProduct_FormClosing);
            this.Load += new System.EventHandler(this.AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allproducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quentity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button updatbtn;
        private System.Windows.Forms.Button Clearbtn;
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView allproducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricepro;
        private System.Windows.Forms.DataGridViewTextBoxColumn quent;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn type2;
        private System.Windows.Forms.DataGridViewTextBoxColumn type3;
        private System.Windows.Forms.DataGridViewTextBoxColumn namepro;
        private System.Windows.Forms.NumericUpDown quentity;
        private System.Windows.Forms.NumericUpDown price;
        private System.Windows.Forms.ComboBox type1;
        private System.Windows.Forms.ComboBox type_3;
        private System.Windows.Forms.ComboBox type_2;
    }
}