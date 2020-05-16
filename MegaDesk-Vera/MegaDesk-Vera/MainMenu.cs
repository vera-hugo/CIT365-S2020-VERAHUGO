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
            Application.Exit();

        }


        //private void MainMenu_Load(object sender, EventArgs e)
        //{


        //}
    }
}
