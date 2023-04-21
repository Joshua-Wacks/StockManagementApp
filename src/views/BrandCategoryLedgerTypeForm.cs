using ConnectionNS;
using ModelsNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementApp.src.views
{
    public partial class BrandCategoryLedgerTypeForm : Form
    {
        public BrandCategoryLedgerTypeForm()
        {
            InitializeComponent();
        }
        private Connection connection = new Connection();

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            if (txtBrandName.Text == "")
            {
                MessageBox.Show("Please add a Brand Name");
            }
            string brandName = txtBrandName.Text;
            connection.insertBrand(brandName);
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text == "")
            {
                MessageBox.Show("Please add a Category Name");
            }
            string categoryName = txtCategoryName.Text;
            connection.insertCategory(categoryName);
        }

        private void btnLedgerType_Click(object sender, EventArgs e)
        {
            if (txtLedgerTypeName.Text == "")
            {
                MessageBox.Show("Please add a LedgerType Name");
            }
            string ledgerTypeName = txtLedgerTypeName.Text;
            connection.insertLedgerType(ledgerTypeName);
        }
    }
}
