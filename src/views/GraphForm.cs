using ConnectionNS;
using ModelsNS;
using ScottPlot;
using StockManagementApp.src.models;

namespace StockManagementApp
{
    public partial class GraphForm : Form
    {

        private void showGraph()
        {
            Connection conn = new Connection();

            List<ItemLedger>  itemLedgers = conn.getAllItemLedgers();
            MessageBox.Show(itemLedgers.Count + "");

            String[] dataX = { "Jan", "Feb", "March", "April", "May", "June", "July", "Aug", "Sept", "Oct", "Novem", "Dec" };
            double[] xPositions = new double[12];
            double[] dataY = new double[12];

            for (int i = 0; i < 12; i++)
            {
                xPositions[i] = i;
                dataY[i] = 0;
            }
            int count = 0;

            foreach (ItemLedger ledger in itemLedgers)
            {

                if (ledger.getLedgerTypeID() == (int)ELedgerType.Sale)
                {
                    int month = ledger.getDateOccured().Month-1;
                    dataY[month] = dataY[month]+  ledger.getQuantity();
                    

                }

            }


            formsPlot.Plot.AddScatter(xPositions, dataY);
            formsPlot.Plot.XAxis.ManualTickPositions(xPositions, dataX);

            formsPlot.Refresh();

        }

        public GraphForm()
        {
            InitializeComponent();
            comboBoxOverall.SelectedItem = comboBoxOverall.Items[0].ToString();
            comboBoxLedgerType.SelectedItem = comboBoxLedgerType.Items[0].ToString();
            comboBoxTime.SelectedItem = comboBoxTime.Items[0].ToString();


            formsPlot.Plot.Style(Style.Black);
            formsPlot.Refresh();

        }

        private Boolean checkBoxes()
        {
            if(comboBoxOverall.SelectedText == "")
            {
                MessageBox.Show("Please Ensure all comboboxes have a value");
                return false;
            }
            return true;
        }

        private void viewGraphBtn_Click(object sender, EventArgs e)
        {
            showGraph();

      /*      if (checkBoxes()){
            }*/
            
        }

    }
}