using ConnectionNS;
using ModelsNS;

namespace StockManagementApp
{
    public partial class GraphForm : Form
    {
        private void DynamicButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dynamic button is clicked");
        }
        private void CreateDynamicButton()
        {

            // Create a Button object  
            Button dynamicButton = new Button();

            // Set Button properties  
            dynamicButton.Height = 40;
            dynamicButton.Width = 300;
            dynamicButton.BackColor = Color.Red;
            dynamicButton.ForeColor = Color.Blue;
            dynamicButton.Location = new Point(20, 150);
            dynamicButton.Text = "I am Dynamic Button";
            dynamicButton.Name = "DynamicButton";
            dynamicButton.Font = new Font("Georgia", 16);

            // Add a Button Click Event handler  
            dynamicButton.Click += new EventHandler(DynamicButton_Click);

            // Add Button to the Form. Placement of the Button  
            // will be based on the Location and Size of button  
            Controls.Add(dynamicButton);
        }
        /// <summary>  
        /// Button click event handler  
        /// </summary>  

        /// <param name="sender"></param>  
        /// <param name="e"></param>  

        

        public GraphForm()
        {
            InitializeComponent();
            CreateDynamicButton();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection connnection = new Connection();
            List<Item> list = connnection.getAllItems();
            foreach (Item item in list) { 
                Console.WriteLine(item.getName());
            }
            dbLabel.Text = (list[0].getName());

        }

    }
}