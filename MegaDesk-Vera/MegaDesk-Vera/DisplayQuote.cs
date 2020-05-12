﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        
    }   
}
