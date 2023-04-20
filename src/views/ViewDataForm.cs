using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelsNS;
using ConnectionNS;

namespace StockManagementApp

{
    public partial class ViewDataForm : Form
    {
        public ViewDataForm()
        {
            InitializeComponent();
        }

        private Connection connection = new Connection();

        private void btnBrands_Click(object sender, EventArgs e)
        {

            List<Brand> brands = new List<Brand>();
            brands = connection.getAllBrands();
            BindingList<Brand> bindingBrands = new BindingList<Brand>(brands);
            dgvTables.DataSource = brands;
            //dgvTables.Refresh();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Test");
            List<Item> items = new List<Item>();
            items = connection.getAllItems();
            dgvTables.DataSource = items;
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            List<Category> categories = new List<Category>();
            categories = connection.getAllCategories();
            dgvTables.DataSource = categories;
        }

        private void btnItemLedger_Click(object sender, EventArgs e)
        {
            List<ItemLedger> itemLedgers = new List<ItemLedger>();
            itemLedgers = connection.getAllItemLedgers();
            dgvTables.DataSource = itemLedgers;
        }

        private void btnLedgerTypes_Click(object sender, EventArgs e)
        {
            List<LedgerType> ledgers = new List<LedgerType>();
            ledgers = connection.getAllLedgerTypes();
            dgvTables.DataSource = ledgers;
        }

        private void btnBrandSearchByName_Click(object sender, EventArgs e)
        {
            if (txtBrandName.Text == "")
            {
                MessageBox.Show("Please enter a brand name");
            }
            string brandName = txtBrandName.Text;

            Brand brand = connection.getBrand(brandName);
            if (brand != null)
            {
                dgvBrands.DataSource = brand;
            }
            else
            {
                MessageBox.Show("Brand name " + brandName + " does not exist");
            }
        }

        private void btnBrandSearchByID_Click(object sender, EventArgs e)
        {
            if (txtBrandID.Text == "")
            {
                MessageBox.Show("Please enter a brand ID");
            }
            int brandID = Convert.ToInt32(txtBrandID.Text);

            Brand brand = connection.getBrand(brandID);
            if (brand != null)
            {
                dgvBrands.DataSource = brand;
            }
            else
            {
                MessageBox.Show("Brand ID " + brandID + " does not exist");
            }
        }

        private void btnItemSearchByName_Click(object sender, EventArgs e)
        {
            if (txtItemName.Text == "")
            {
                MessageBox.Show("Please enter an item name");
            }
            string itemName = txtItemName.Text;

            Item item = connection.getItem(itemName);
            if (item != null)
            {
                dgvItems.DataSource = item;
            }
            else
            {
                MessageBox.Show("Item name " + itemName + " does not exist");
            }
        }

        private void btnItemSearchByID_Click(object sender, EventArgs e)
        {
            if (txtItemID.Text == "")
            {
                MessageBox.Show("Please enter an Item ID");
            }

            int itemID = Convert.ToInt32(txtItemID.Text);
            Item item = connection.getItem(itemID);
            if (item != null)
            {
                dgvItems.DataSource = item;
            }
            else
            {
                MessageBox.Show("Item Id " + itemID + " does not exist");
            }
        }

        private void btnCategorySearchByName_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text == "")
            {
                MessageBox.Show("Please enter a Category Name");
            }

            string categoryName = txtCategoryName.Text;
            Category category = connection.getCategory(categoryName);
            if (category != null)
            {
                dvgCategories.DataSource = category;
            }
            else
            {
                MessageBox.Show("Category name " + categoryName + " does not exist");
            }
        }

        private void btnCategorySearchByID_Click(object sender, EventArgs e)
        {
            if (txtCategoryID.Text == "")
            {
                MessageBox.Show("Please enter a Category ID");
            }
            int categoryID = Convert.ToInt32(txtCategoryID.Text);
            Category category = connection.getCategory(categoryID);
            if (category != null)
            {
                dvgCategories.DataSource = category;
            }
            else
            {
                MessageBox.Show("Category ID " + categoryID + " does not exist");
            }
        }

        private void btnItemLedgerNameSearch_Click(object sender, EventArgs e)
        {
            if (txtItemLedgerName.Text == "")
            {
                MessageBox.Show("Please enter an Item Ledger Name");
            }
            int itemID = Convert.ToInt32(txtItemLedgerName.Text);
            List<ItemLedger> itemLedger = connection.getLedgerItemByItemID(itemID);
            if (itemLedger != null)
            {
                dgvItemLedgers.DataSource = itemLedger;
            }
            else
            {
                MessageBox.Show("Item Ledger with Item Id " + itemID + " does not exist");
            }
        }

        private void btnLedgerTypeNameSearch_Click(object sender, EventArgs e)
        {
            if (txtLedgerTypeName.Text == "")
            {
                MessageBox.Show("Please enter a Ledger Type Name");
            }
            string ledgerTypeName = txtLedgerTypeName.Text;
            LedgerType ledgerType = connection.getLedgerType(ledgerTypeName);
            if (ledgerType != null)
            {
                dgvLedgerTypes.DataSource = ledgerType;
            }
            else
            {
                MessageBox.Show("Ledger Type name " + ledgerTypeName + " does not exist");
            }
        }

        private void btnLedgerTypeID_Click(object sender, EventArgs e)
        {
            if (txtLedgerTypeID.Text == "")
            {
                MessageBox.Show("Please enter a Ledger Type ID");
            }
            int ledgerTypeID = Convert.ToInt32(txtLedgerTypeID.Text);
            LedgerType ledgerType = connection.getLedgerType(ledgerTypeID);
            if (ledgerType != null)
            {
                dgvLedgerTypes.DataSource = ledgerType;
            }
            else
            {
                MessageBox.Show("Ledger Type ID " + ledgerTypeID + " does not exist");
            }
        }

        private void btnItemLedgerIDSearch_Click(object sender, EventArgs e)
        {
            if (txtItemLedgerID.Text == "")
            {
                MessageBox.Show("Please enter a Ledger Type ID");
            }
            int ledgerTypeID = Convert.ToInt32(txtItemLedgerID.Text);
            List<ItemLedger> itemLedger = connection.getLedgerItemByLedgerTypeID(ledgerTypeID);
            if (itemLedger != null)
            {
                dgvItemLedgers.DataSource = itemLedger;
            }
            else
            {
                MessageBox.Show("Item ledger ID " + ledgerTypeID + " does not exist");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDateOccurred.Text == "")
            {
                MessageBox.Show("Please enter date occurred");
            }
            string date = txtDateOccurred.Text;
            List<ItemLedger> itemLedgers = connection.getLedgerItemByDateOccured(date);
            if (itemLedgers != null)
            {
                dgvItemLedgers.DataSource = itemLedgers;
            }
            else
            {
                MessageBox.Show("No item legders found for date " + date);
            }
        }

/*        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ViewDataForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "ViewDataForm";
            this.Load += new System.EventHandler(this.ViewDataForm_Load);
            this.ResumeLayout(false);

        }*/

        private void ViewDataForm_Load(object sender, EventArgs e)
        {

        }

    }
}
