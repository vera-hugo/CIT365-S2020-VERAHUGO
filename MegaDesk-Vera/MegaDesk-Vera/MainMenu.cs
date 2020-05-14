using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MegaDesk_Vera
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void addNewQuoteButtom_Click(object sender, EventArgs e)
        {
            Form AddNewQuoteForm = new AddQuote();
            AddNewQuoteForm.Show();
            Hide();


        }

        private void viewQuotesButtom_Click(object sender, EventArgs e)
        {
            Form ViewQuotesForm = new ViewAllQuotes();
            ViewQuotesForm.Show();
            Hide();

        }

        private void searchQuotesButtom_Click(object sender, EventArgs e)
        {
            Form SearchQuotesForm = new SearchQuotes();
            SearchQuotesForm.Show();
            Hide();

        }

        private void exitButtom_Click(object sender, EventArgs e)
        {
            //Close the Main Menu Form
            Close();

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(json);

            Desk desk = new Desk(10, 10, 10, DesktopMaterial.Laminate);
            DeskQuote deskQuote = new DeskQuote(desk, 10, "hola", DateTime.Now);
            jsonVariables jsonLine = new jsonVariables(deskQuote);
            //string tempJsonString = JsonConvert.SerializeObject(jsonLine, Formatting.Indented);
            //MessageBox.Show(tempJsonString);
            List<jsonVariables> list = new List<jsonVariables>();
            list.Add(jsonLine);
            list.Add(jsonLine);
            for (int i = 0; i < list.Count; i++)
            {
                MessageBox.Show(JsonConvert.SerializeObject(list[i], Formatting.Indented));
            }

            File.WriteAllText(@"E:\GitHub\CIT365-S2020-VERAHUGO\MegaDesk-Vera\MegaDesk-Vera\bin\quotes.json",
                JsonConvert.SerializeObject(list, Formatting.Indented));


            string json = File.ReadAllText(@"E:\GitHub\CIT365-S2020-VERAHUGO\MegaDesk-Vera\MegaDesk-Vera\bin\quotes.json");
            MessageBox.Show(json);

            List<jsonVariables> playerList = new List<jsonVariables>();
            playerList = JsonConvert.DeserializeObject<List<jsonVariables>>(json);


            Desk desk2 = new Desk(110, 110, 110, DesktopMaterial.Oak);
            DeskQuote deskQuote2 = new DeskQuote(desk, 110, "Mr. Been", DateTime.Now);
            jsonVariables jsonLine2 = new jsonVariables(deskQuote2);
            list.Add(jsonLine);

            File.WriteAllText(@"E:\GitHub\CIT365-S2020-VERAHUGO\MegaDesk-Vera\MegaDesk-Vera\bin\quotes.json",
                JsonConvert.SerializeObject(list, Formatting.Indented));

            // MessageBox.Show(Directory.GetCurrentDirectory() + "\\quotes.json");
        }
    }
}
