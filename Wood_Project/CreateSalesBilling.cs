using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Wood_Project
{
    public partial class CreateSalesBilling : Form
    {
        private Wood_ProjectEntities context;
        int selectedrow;
        public CreateSalesBilling()
        {
            InitializeComponent();
            context = new Wood_ProjectEntities();
            loadnameproduct();
        }
        
        private void loadnameproduct()
        {
            var productsname = context.Products.Select(s => s.Name).Distinct().ToArray();
            proname.Items.AddRange(productsname);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            //string _name = proname.SelectedValue.ToString();
            //var query = from a in context.Products
            //            where (a.ID = _name).Select(a.Price);


            allproductinvoice.Rows.Add(
                proname.SelectedValue.ToString(),
                addquent.Value.ToString(),
                "44".ToString(),
                "1".ToString()


                );
        }

        private void allproductinvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedrow = e.RowIndex;
            DataGridViewRow row = allproductinvoice.Rows[selectedrow];
            proname.Text = row.Cells[3].Value.ToString();
            addquent.Value = int.Parse(row.Cells[2].Value.ToString());
          
           

        }
    }
}
