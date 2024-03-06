using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Wood_Project
{
    public partial class AddProduct : Form
    {
        private Wood_ProjectEntities context;
        int selectedrow;
        public AddProduct()
        {
            InitializeComponent();
            context = new Wood_ProjectEntities();

            getdata();
        }

        private void getdata()
        {
            var query = from a in context.Products
                        select a;
            allproducts.Rows.Clear();
            foreach (var item in query)
            {
                allproducts.Rows.Add(
                    item.Total_Price,
                    item.Price,
                    item.Quentity,                  
                    item.Type3,
                    item.Type2,
                    item.Type1,
                    item.Name             
                    );
            }

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (name.Text == "" ||
               type1.SelectedIndex == -1 ||
               type_2.SelectedIndex == -1||
                type_3.SelectedIndex == -1 ||
                quentity.Value == 0||
                  price.Value == 0
                )
            {
                MessageBox.Show("Invalid Data", "Failed to Add", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                // data.Rows.Add(name.Text, int.Parse(price.Text), state.SelectedItem, area.Text);
                Product prod1 = new Product()
                {
                    Name = name.Text,
                    Type1 = type1.SelectedItem.ToString(),
                    Type2 = type_2.SelectedItem.ToString(),
                    Type3 = type_3.SelectedItem.ToString(),
                    Price = int.Parse(price.Value.ToString()),
                    Quentity = int.Parse(quentity.Value.ToString()),
                    Total_Price = (int.Parse(price.Value.ToString())* int.Parse(quentity.Value.ToString()))

                };
              context.Products.Add(prod1);
               context.SaveChanges();

                getdata();

                name.Text = "";
                price.Text = "";
                type1.Text = "";
                type_2.Text = "";
                type_3.Text = "";
                price.Value = 0;
                quentity.Value = 0;
               

            }
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            getdata();
        }
        private void allproducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedrow = e.RowIndex;
            DataGridViewRow row = allproducts.Rows[selectedrow];
            name.Text = row.Cells[6].Value.ToString();
            type1.Text = row.Cells[5].Value.ToString();
            type_2.Text = row.Cells[4].Value.ToString();
            type_3.Text = row.Cells[3].Value.ToString();
            quentity.Value = int.Parse(row.Cells[2].Value.ToString());
            price.Value = int.Parse(row.Cells[1].Value.ToString());
        }
      

        private void updatbtn_Click(object sender, EventArgs e)
        {
            if (name.Text == "" ||
               type1.SelectedIndex == -1 ||
               type_2.SelectedIndex == -1 ||
                type_3.SelectedIndex == -1 ||
                quentity.Value == 0 ||
                  price.Value == 0
                )
            {

                MessageBox.Show("Invalid Data", "Failed to Add", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DataGridViewRow row = allproducts.Rows[selectedrow];

                string _Name = row.Cells[6].FormattedValue.ToString();

                Product prod1 = context.Products.Select(k => k).Where(k => k.Name == _Name).FirstOrDefault();

                prod1.Name = name.Text;
                prod1.Type1 = type1.SelectedItem.ToString();
                prod1.Type2 = type_2.SelectedItem.ToString();
                prod1.Type3 = type_2.SelectedItem.ToString();
                prod1.Price = int.Parse(price.Value.ToString());
                prod1.Quentity = int.Parse(quentity.Value.ToString());
                prod1.Total_Price = (int.Parse(price.Value.ToString()) * int.Parse(quentity.Value.ToString()));


                context.SaveChanges();

                getdata();


                name.Text = "";
                price.Text = "";
                type1.Text = "";
                type_2.Text = "";
                type_3.Text = "";
                price.Value = 0;
                quentity.Value = 0;

            }

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (name.Text == "" ||
              type1.SelectedIndex == -1 ||
              type_2.SelectedIndex == -1 ||
               type_3.SelectedIndex == -1 ||
               quentity.Value == 0 ||
                 price.Value == 0
               )
                {

                    MessageBox.Show("Invalid Data", "Failed to Add", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    var result = MessageBox.Show("Are you sure To Delete  ", "Delete Form",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

                    // e.Cancel = (result == DialogResult.No);
                    if (result == DialogResult.Yes)
                    {
                        DataGridViewRow row = allproducts.Rows[selectedrow];
                        string _Name = row.Cells[6].FormattedValue.ToString();
                        Product std1 = context.Products.Select(k => k).Where(k => k.Name == _Name).FirstOrDefault();

                        context.Products.Remove(std1);
                        context.SaveChanges();
                        getdata();


                        name.Text = "";
                        price.Text = "";
                        type1.Text = "";
                        type_2.Text = "";
                        type_3.Text = "";
                        price.Value = 0;
                        quentity.Value = 0;

                    }
                    else
                    {

                        name.Text = "";
                        price.Text = "";
                        type1.Text = "";
                        type_2.Text = "";
                        type_3.Text = "";
                        price.Value = 0;
                        quentity.Value = 0;

                    }


                }
            }
            catch
            {
                MessageBox.Show("Invalid Data");
            }
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {


            name.Text = "";
            price.Text = "";
            type1.Text = "";
            type_2.Text = "";
            type_3.Text = "";
            price.Value = 0;
            quentity.Value = 0;

        }

        private void AddProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("هل تريد قفل الصفحة  ", "إلغاء الصفحة",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question);

            e.Cancel = (result == DialogResult.No);
        }

       
    }

}
