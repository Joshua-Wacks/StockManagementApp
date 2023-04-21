using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementApp
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnViewStock_Click(object sender, EventArgs e)
        {
            ViewDataForm viewDataForm = new ViewDataForm();
            viewDataForm.ShowDialog();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            GraphForm graphForm = new GraphForm();
            graphForm.ShowDialog();
        }
    }
}
