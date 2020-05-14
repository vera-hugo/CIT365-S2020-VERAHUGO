using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MegaDesk_Vera
{
    public partial class DisplayQuote : Form
    {
        DeskQuote myDeskQuote = new DeskQuote(AddQuote.myDesk, AddQuote.dayRush, AddQuote.userName, DateTime.Now);

        public DisplayQuote()
        {
            InitializeComponent();
            label4.Text = myDeskQuote.getdate().ToString("dd MMMM yyyy");

        }


        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            myDeskQuote.GetRushOrder();
            label2.Text = AddQuote.userName;
            //int widthDesk = AddQuote.myDesk.getwidthDesk();
            label6.Text = Convert.ToString(myDeskQuote.getArea()) + " in²" ;
            label12.Text = myDeskQuote.getBaseCost().ToString("C", CultureInfo.CurrentCulture);
            label17.Text = Convert.ToString(myDeskQuote.getmyDesk().getsurfaceMaterial());
            label8.Text = Convert.ToString(myDeskQuote.getmyDesk().getdrawersDesk());
            label20.Text = Convert.ToString(myDeskQuote.getdayRush());
            label15.Text = myDeskQuote.getextraAreaCost().ToString("C", CultureInfo.CurrentCulture);
            label18.Text = myDeskQuote.getsurfaceMaterialCost().ToString("C", CultureInfo.CurrentCulture);
            label24.Text = myDeskQuote.getdrawersCost().ToString("C", CultureInfo.CurrentCulture);
            label21.Text = myDeskQuote.getrushCost().ToString("C", CultureInfo.CurrentCulture);
            label23.Text = myDeskQuote.finalCost().ToString("C", CultureInfo.CurrentCulture);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form AddQuoteForm = new AddQuote();
            AddQuoteForm.Show();
            Hide();
        }

        private void button1_Click(object sender, FormClosedEventArgs e)
        {
            Form AddQuoteForm = new AddQuote();
            AddQuoteForm.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText("\\quotes.json");
            List<jsonVariables> list = new List<jsonVariables>();
            jsonVariables a = new jsonVariables(myDeskQuote);
            list.Add(a);
            list = JsonConvert.DeserializeObject<List<jsonVariables>>(json);

            Desk desk = new Desk(5, 5, 5, DesktopMaterial.Veneer);
            DeskQuote deskQuote = new DeskQuote(desk, 1, "Hello there", DateTime.Now);
            jsonVariables myJsonVariables = new jsonVariables(deskQuote);

            MessageBox.Show(myJsonVariables.CustomeName);

            list.Add(myJsonVariables);

            //string myJsonFile = JsonConvert.DeserializeObject();
            string myJsonFile = JsonConvert.SerializeObject(list, Formatting.Indented);
            
            string path = Directory.GetCurrentDirectory() + "\\quotes.json";
            //MessageBox.Show(myJsonFile);
            File.WriteAllText(path, myJsonFile);
        }
    }   
}
