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
    public partial class AddQuote : Form
    {
        Desk myDesk = new Desk();

        public static string userName;
          

        public AddQuote()
        {
            InitializeComponent();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Form MainMenuForm = new MainMenu();
            MainMenuForm.Show();
            Hide();
        }

        public bool checkWidth()
        {
            int width = Convert.ToInt32(this.textBox2.Text);

            //int test = myDesk.

            if (width < myDesk.getMINWIDTH() || width > myDesk.getMAXWIDTH())
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool checkDepth()
        {
            int width = Convert.ToInt32(this.textBox6.Text);

            if (width < myDesk.getMINDEPTH() || width > myDesk.getMAXDEPTH())
            {
                return false;
            }
            else
            {
                return true;
            }

        }


        private void TextBox2_Validating(object sender, CancelEventArgs e)
        {
            
            bool result = checkWidth();
            string errorMessage = "Width does not belong to the correct range (24-96)";

            if (!result)
            {
                e.Cancel = true;
                textBox2.Select(0, textBox2.Text.Length);
                System.Windows.Forms.MessageBox.Show(errorMessage);
            }
        }

      
        private void TextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == 13)))
            {
                MessageBox.Show("please enter digits only");
                e.Handled = false;
            }
           
                        
        }

       private void TextBox6_Validating(object sender, CancelEventArgs e)
        {

            bool result = checkDepth();
            string errorMessage = "Width does not belong to the correct range (12-48)";

            if (!result)
            {
                e.Cancel = true;
                textBox6.Select(0, textBox6.Text.Length);
                System.Windows.Forms.MessageBox.Show(errorMessage);
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            userName = textBox1.Text;
            Form DisplayQuoteForm = new DisplayQuote();
            DisplayQuoteForm.Show();
            Hide();

        }
    }

    
}
