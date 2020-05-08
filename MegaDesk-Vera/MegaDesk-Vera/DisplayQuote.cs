using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Vera
{
    public partial class DisplayQuote : Form
    {
        DeskQuote myDeskQuote = new DeskQuote(AddQuote.myDesk, AddQuote.dayRush, AddQuote.userName, DateTime.Now.ToString("d MMMM yyyy"));

        public DisplayQuote()
        {
            InitializeComponent();
            label4.Text =  DateTime.Now.ToString("d MMMM yyyy");
        }


        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            label2.Text = AddQuote.userName;
            //int widthDesk = AddQuote.myDesk.getwidthDesk();
            label6.Text = Convert.ToString(AddQuote.myDesk.getwidthDesk() * AddQuote.myDesk.getdepthDesk());


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
    }   
}
