using ConnectionNS;
using ModelsNS;
using ScottPlot;
using StockManagementApp.src.models;

namespace StockManagementApp
{
    public partial class GraphForm : Form
    {

        private void showGraph(String items,String action,String time)
        {
            Connection conn = new Connection();

/*            switch (items)
            {
                case "All Items":

                    break;
                default:
                    Console.WriteLine();
                    break;

*//*By Brand
By Category*//*
            }*/
          //  if (items.Equals())

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
            for(int i =0 ; i < itemLedgers.Count;i++)
            {
                ItemLedger ledger = itemLedgers[i];
                if (ledger.ledgerTypeID == (int)ELedgerType.Sale)
                {
                    int month = ledger.dateOccured.Month - 1;
                    dataY[month] = dataY[month] + ledger.quantity;

                }
            }


/*            foreach (ItemLedger ledger in itemLedgers)
            {

                if (ledger.getLedgerTypeID() == (int)ELedgerType.Sale)
                {
                    int month = ledger.getDateOccured().Month-1;
                    dataY[month] = dataY[month]+  ledger.getQuantity();
                    

                }

            }*/


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

        private void viewGraphBtn_Click(object sender, EventArgs e)
        {

            String item = comboBoxOverall.SelectedItem.ToString();
            String action = comboBoxLedgerType.SelectedItem.ToString();
            String time = comboBoxTime.SelectedItem.ToString();

            showGraph(item,action,time);

        }

    }
}