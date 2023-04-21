using ConnectionNS;
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

namespace StockManagementApp.src.views
{
    public partial class Input : Form
    {

        String BrandName;
        String CategoryName;
        String NameItem;
        String Action;
        decimal stock;
        Connection conn = new Connection();
        public Input()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            NameItem = textBoxName.Text;
        }

        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            BrandName = comboBoxBrand.Text;
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoryName = comboBoxCategories.Text;
        }

        private void comboBoxAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            Action = comboBoxAction.Text;
        }

        private void Input_Load(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void StockNumber(object sender, EventArgs e)
        {
            stock = numericUpDownStock.Value;
        }

        private void SubmitButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show(NameItem + BrandName + CategoryName + Action + stock);

            Brand brand = conn.getBrand(BrandName);
            Category category = conn.getCategory(CategoryName);
            LedgerType ledgerType = conn.getLedgerType(Action);
            Item item = new Item(NameItem, category.categoryID, brand.brandId, (int)stock);
            ItemLedger itemLedger = new ItemLedger(ledgerType.ledgerTypeID, item.itemID, (int)stock, DateTime.Now);

            MessageBox.Show(brand.getName() + category.name + ledgerType.name + item.name);

            if (Action.ToLower() == "restock" || Action.ToLower() == "return")
            {
                conn.insertItem(item);
                conn.insertLedgerItem(itemLedger);
            }
            else
            {
                conn.deleteLedgerItem(itemLedger.ledgerID);
                conn.deleteItem(item.itemID);
            }
        }
    }
}
