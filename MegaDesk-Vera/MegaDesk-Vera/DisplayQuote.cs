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
        DeskQuote myDeskQuote = new DeskQuote(AddQuote.myDesk, AddQuote.dayRush, AddQuote.userName, DateTime.Now);

        public DisplayQuote()
        {
            InitializeComponent();
            label4.Text = Convert.ToString(myDeskQuote.getdate());
        }


        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            label2.Text = AddQuote.userName;
            //int widthDesk = AddQuote.myDesk.getwidthDesk();
            label6.Text = Convert.ToString(myDeskQuote.getArea());
            label12.Text = string.Format("{0:#,##0.00}",(myDeskQuote.getBaseCost()));
            label17.Text = Convert.ToString(myDeskQuote.getmyDesk().getsurfaceMaterial());
            label8.Text = Convert.ToString(myDeskQuote.getmyDesk().getdrawersDesk());
            label20.Text = Convert.ToString(myDeskQuote.getdayRush());
            label15.Text = string.Format("{0:#,##0.00}", (myDeskQuote.getextraAreaCost()));
            label18.Text = string.Format("{0:#,##0.00}", (myDeskQuote.getsurfaceMaterialCost()));
            label24.Text = string.Format("{0:#,##0.00}", (myDeskQuote.getdrawersCost()));
            label21.Text = string.Format("{0:#,##0.00}", (myDeskQuote.getrushCost()));
            label23.Text = string.Format("{0:#,##0.00}", (myDeskQuote.finalCost()));
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
