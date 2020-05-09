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
        public static Desk myDesk = new Desk();
        //public  Desk myDeskone = new Desk();
        public static int dayRush;
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

        public bool checkWidth(object sender, CancelEventArgs e)
        {
            int width = 0;
            try
            {
                 width = Convert.ToInt32(this.textBox2.Text);
            }
            catch (Exception)
            {
                e.Cancel = true;
                // inputWidth.Text = "";
                MessageBox.Show("Please enter only numbers into the width field");
            }

            //int test = myDesk.

            if (width < variablesConstraints.MINWIDTH || width > variablesConstraints.MAXWIDTH)
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

            if (width < variablesConstraints.MINDEPTH || width > variablesConstraints.MAXDEPTH)
            {
                //variablesConstraints.MINDEPTH = 8;
                return false;
            }
            else
            {
                return true;
            }

        }


        private void TextBox2_Validating(object sender, CancelEventArgs e)
        {
            
            bool result = checkWidth(sender, e);
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
            dayRush = Convert.ToInt32(comboBox3.Text);
            myDesk.setwidthDesk(Convert.ToInt32(textBox2.Text));
            myDesk.setdepthDesk(Convert.ToInt32(textBox6.Text));
            myDesk.setdrawersDesk(Convert.ToInt32(comboBox1.Text));

            surfaceMaterial tempMaterial = surfaceMaterial.Veneer;
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    tempMaterial = surfaceMaterial.Oak;
                break;
                case 1:
                    tempMaterial = surfaceMaterial.Laminate;
                break;
                case 2:
                    tempMaterial = surfaceMaterial.Pine;
                break;
                case 3:
                    tempMaterial = surfaceMaterial.Rosewood;
                break;
                case 4:
                    tempMaterial = surfaceMaterial.Veneer;
                break;
            }
            myDesk.setsurfaceMaterial(tempMaterial);
            Form DisplayQuoteForm = new DisplayQuote();
            DisplayQuoteForm.Show();
            Hide();

        }

    }

    
}
