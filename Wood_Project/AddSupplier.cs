using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Wood_Project
{
    public partial class AddSupplier : Form
    {
        private Wood_ProjectEntities context;
        int selectedrow;
        public AddSupplier()
        {
            InitializeComponent();
            context = new Wood_ProjectEntities();
            getdata();
        }

        private void getdata()
        {
            var query = from a in context.suppliers
                        select a;
            allsuppliers.Rows.Clear();
            foreach (var item in query)
            {
                allsuppliers.Rows.Add(
                 item.Notes,
                 item.Adress,
                 item.Phone,
                 item.NameCompany,
                 item.Name
            
                    );
            }

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (namesupp.Text == "" ||
               namecomp.Text == "" ||
               phonenum.TextLength!=11 ||
               address.Text == ""
                )
            {
                MessageBox.Show("Invalid Data", "Failed to Add", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                // data.Rows.Add(name.Text, int.Parse(price.Text), state.SelectedItem, area.Text);
                supplier supp1 = new supplier()
                {
                    Name = namesupp.Text,
                    NameCompany = namecomp.Text,
                    Phone = phonenum.Text,
                    Adress = address.Text,
                    Notes = notes.Text                   
                };
                context.suppliers.Add(supp1);
                context.SaveChanges();
                getdata();
                namesupp.Text = "";
                namecomp.Text = "";
                phonenum.Text = "";
                address.Text = "";
            }
        }

        private void updatbtn_Click(object sender, EventArgs e)
        {
            if (namesupp.Text == "" ||
               namecomp.Text == "" ||
               phonenum.Text == "" ||
               address.Text == ""
                )
            {

                MessageBox.Show("Invalid Data", "Failed to Add", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DataGridViewRow row = allsuppliers.Rows[selectedrow];

                string _Name = row.Cells[4].FormattedValue.ToString();

                supplier supp1 = context.suppliers.Select(k => k).Where(k => k.Name == _Name).FirstOrDefault();

                supp1.Name = namesupp.Text;
                supp1.NameCompany = namecomp.Text;
                supp1.Phone = phonenum.Text;
                supp1.Adress = address.Text;
                supp1.Notes = notes.Text;
                context.SaveChanges();

                getdata();



                namesupp.Text = "";
                namecomp.Text = "";
                phonenum.Text = "";
                address.Text = "";
                notes.Text = "";
            }
            }

            private void allsuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
            {
            selectedrow = e.RowIndex;
            DataGridViewRow row = allsuppliers.Rows[selectedrow];
            
            notes.Text = row.Cells[0].Value.ToString();
            address.Text = row.Cells[1].Value.ToString();
            phonenum.Text = row.Cells[2].Value.ToString();
            namecomp.Text = row.Cells[3].Value.ToString();
            namesupp.Text = row.Cells[4].Value.ToString();
            }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (namesupp.Text == "" ||
                namecomp.Text == "" ||
                phonenum.Text == "" ||
                address.Text == ""
                 )
                {

                    MessageBox.Show("Invalid Data", "Failed to Add", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    var result = MessageBox.Show("هل تريد حذف المورد ", "حذف المورد",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

                    // e.Cancel = (result == DialogResult.No);
                    if (result == DialogResult.Yes)
                    {
                        DataGridViewRow row = allsuppliers.Rows[selectedrow];
                        string _Name = row.Cells[4].FormattedValue.ToString();
                        supplier supp1 = context.suppliers.Select(k => k).Where(k => k.Name == _Name).FirstOrDefault();

                        context.suppliers.Remove(supp1);
                        context.SaveChanges();
                        getdata();


                        namesupp.Text = "";
                        namecomp.Text = "";
                        phonenum.Text = "";
                        address.Text = "";
                        notes.Text = "";


                    }
                    else
                    {

                        namesupp.Text = "";
                        namecomp.Text = "";
                        phonenum.Text = "";
                        address.Text = "";
                        notes.Text = "";


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
            namesupp.Text = "";
            namecomp.Text = "";
            phonenum.Text = "";
            address.Text = "";
            notes.Text = "";
        }
    }
}
