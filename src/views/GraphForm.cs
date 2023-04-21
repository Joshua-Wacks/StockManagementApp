using ConnectionNS;
using ModelsNS;
using ScottPlot;
using StockManagementApp.src.models;
using static ScottPlot.Plottable.PopulationPlot;

namespace StockManagementApp
{
    public partial class GraphForm : Form
    {
        private static int firstYearInDb = 2019;
        private void showGraph(String items,String action,String time)
        {
            Connection conn = new Connection();
            List<ItemLedger> itemLedgers = conn.getAllItemLedgers();


            int actionCheck = 1;
            switch (action)
            {
                case "Sales":
                    actionCheck = (int)ELedgerType.Sale;
                    break;

                case "Returns":
                    actionCheck = (int)ELedgerType.Return;
                    break;

                case "Restocks":
                    actionCheck = (int)ELedgerType.Restock;
                    break;

                case "Broken":
                    actionCheck = (int)ELedgerType.Broken;
                    break;
            }



            if (items.Equals("All Items"))
            {
                if (time.Equals("Monthly"))
                {
                    string[] dataX = { "Jan", "Feb", "March", "April", "May", "June", "July", "Aug", "Sept", "Oct", "Novem", "Dec" };
                    double[] xPositions = new double[dataX.Length];
                    double[] dataY = new double[dataX.Length];

                    for (int i = 0; i < dataY.Length; i++)
                    {
                        xPositions[i] = i;
                        dataY[i] = 0;
                    }
                    for (int i = 0; i < itemLedgers.Count; i++)
                    {
                        ItemLedger ledger = itemLedgers[i];
                        if (ledger.ledgerTypeID == actionCheck)
                        {
                            int month = ledger.dateOccured.Month - 1;
                            dataY[month] = dataY[month] + ledger.quantity;

                        }
                    }

                    formsPlot.Plot.AddScatter(xPositions, dataY);
                    formsPlot.Plot.XAxis.ManualTickPositions(xPositions, dataX);
                    
                    //string.Format("{0:D}  {1,6:D}", 634, 868); // result: 634     868

                    formsPlot.Refresh();
                }
                else
                {
                    double[] dataX = { 2019, 2020, 2021, 2022, 2023 };
                    double[] dataY = new double[dataX.Length];
                    for (int i = 0; i < dataY.Length; i++)
                    {
                        dataY[i] = 0;
                    }
                    for (int i = 0; i < itemLedgers.Count; i++)
                    {
                        ItemLedger ledger = itemLedgers[i];
                        if (ledger.ledgerTypeID == actionCheck)
                        {
                            int year = ledger.dateOccured.Year - firstYearInDb;

                            dataY[year] = dataY[year] + ledger.quantity;
                        }
                    }

                    formsPlot.Plot.AddScatter(dataX, dataY);

                    formsPlot.Refresh();


                }
            }
            else if (items.Equals("By Brand"))
            {
                string msg = "Please enter a brandID below\n\nName : BrandID\n__________________________________\n";
                List<Brand> brands = conn.getAllBrands();
                foreach (Brand brand in brands)
                {
                    msg = msg + brand.name + " : " + brand.brandId + "\n";
                }
                String resultStr = Microsoft.VisualBasic.Interaction.InputBox(msg, "brandID", "1");
                if(!int.TryParse(resultStr, out int result))
                {
                    MessageBox.Show("Please enter a valid brandID");
                    return;
                }
                if (result < 0 || result > brands.Count)
                {
                    MessageBox.Show("Please enter a valid brandID");
                    return;
                }
                if (time.Equals("Monthly"))
                {
                    string[] dataX = { "Jan", "Feb", "March", "April", "May", "June", "July", "Aug", "Sept", "Oct", "Novem", "Dec" };
                    double[] xPositions = new double[dataX.Length];
                    double[] dataY = new double [dataX.Length];


                    for (int i = 0; i < dataX.Length; i++)
                    {
                        xPositions[i] = i;
                        dataY[i] = 0;
                    }

                    for (int i = 0; i < itemLedgers.Count; i++)
                    {
                        ItemLedger ledger = itemLedgers[i];
                        if (ledger.ledgerTypeID == actionCheck && result == conn.getItem(ledger.itemID).brandId)
                        {
                            int month = ledger.dateOccured.Month - 1;
                            dataY[month] = dataY[ month] + ledger.quantity;

                        }
                    }

                    formsPlot.Plot.AddScatter(xPositions, dataY);

                    formsPlot.Plot.XAxis.ManualTickPositions(xPositions, dataX);

                    formsPlot.Refresh();
                }
                else
                {
                    double[] dataX = { 2019, 2020, 2021, 2022, 2023 };
                    double[] dataY = new double[dataX.Length];
                    for (int i = 0; i < dataY.Length; i++)
                    {
                        dataY[i] = 0;
                    }
                    for (int i = 0; i < itemLedgers.Count; i++)
                    {
                        ItemLedger ledger = itemLedgers[i];
                        if (ledger.ledgerTypeID == actionCheck && result == conn.getItem(ledger.itemID).brandId)
                        {
                            int year = ledger.dateOccured.Year - firstYearInDb;

                            dataY[year] = dataY[year] + ledger.quantity;
                        }
                    }

                    formsPlot.Plot.AddScatter(dataX, dataY);

                    formsPlot.Refresh();
                }
            }
            else
            {
                string msg = "Please enter a CategoryID below\n\nName : CategoryID\n__________________________________\n";
                List<Category> categories = conn.getAllCategories();
                foreach(Category category in categories)
                {
                    msg = msg + category.name + "\t:\t" + category.categoryID + "\n";
                }
                String resultStr = Microsoft.VisualBasic.Interaction.InputBox(msg, "CategoryID", "1");
                if (!int.TryParse(resultStr, out int result))
                {
                    MessageBox.Show("Please enter a valid CategoryID");
                    return;
                }
                if (result < 0 || result > categories.Count)
                {
                    MessageBox.Show("Please enter a valid CategoryID");
                    return;
                }

                if (time.Equals("Monthly"))
                {
                    string[] dataX = { "Jan", "Feb", "March", "April", "May", "June", "July", "Aug", "Sept", "Oct", "Novem", "Dec" };
                    double[] xPositions = new double[dataX.Length];
                    double[] dataY = new double[dataX.Length];


                    for (int i = 0; i < dataX.Length; i++)
                    {
                        xPositions[i] = i;
                        dataY[i] = 0;
                    }

                    for (int i = 0; i < itemLedgers.Count; i++)
                    {
                        ItemLedger ledger = itemLedgers[i];
                        if (ledger.ledgerTypeID == actionCheck && result == conn.getItem(ledger.itemID).categoryID)
                        {
                            int month = ledger.dateOccured.Month - 1;
                            dataY[month] = dataY[month] + ledger.quantity;

                        }
                    }

                    formsPlot.Plot.AddScatter(xPositions, dataY);

                    formsPlot.Plot.XAxis.ManualTickPositions(xPositions, dataX);

                    formsPlot.Refresh();
                }
                else
                {
                    double[] dataX = { 2019, 2020, 2021, 2022, 2023 };
                    double[] dataY = new double[dataX.Length];
                    for (int i = 0; i < dataY.Length; i++)
                    {
                        dataY[i] = 0;
                    }
                    for (int i = 0; i < itemLedgers.Count; i++)
                    {
                        ItemLedger ledger = itemLedgers[i];
                        if (ledger.ledgerTypeID == actionCheck && result == conn.getItem(ledger.itemID).categoryID)
                        {
                            int year = ledger.dateOccured.Year - firstYearInDb;

                            dataY[year] = dataY[year] + ledger.quantity;
                        }
                    }

                    formsPlot.Plot.AddScatter(dataX, dataY);

                    formsPlot.Refresh();
                }
            }



           
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
            formsPlot.Plot.Clear();

            String item = comboBoxOverall.SelectedItem.ToString();
            String action = comboBoxLedgerType.SelectedItem.ToString();
            String time = comboBoxTime.SelectedItem.ToString();

            

            showGraph(item,action,time);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}