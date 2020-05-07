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
        public int minWidth = 24;
        public int maxWidth = 96;
        //public int minDepth = 12;
        //public int maxDepth = 48;




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

            if (width < minWidth || width > maxWidth)
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
            int input = 0;
            // while (!(e.KeyChar == 13))
            //{
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == 13)))
            {
                MessageBox.Show("please enter digits only");
                e.Handled = false;
            }
            else
            {
                int.TryParse(textBox6.Text, out input);
            }
            // }
            if (!(input >= 12 && input <= 48))
            {
                MessageBox.Show("Please enter numbers between 12 and 48");
            }
            
        }
    }

    
}
