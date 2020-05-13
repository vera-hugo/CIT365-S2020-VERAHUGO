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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        }

        List<DesktopMaterial> materials = new List<DesktopMaterial>();



        private void button1_Click(object sender, EventArgs e)
        {
            Form MainMenuForm = new MainMenu();
            MainMenuForm.Show();
            Hide();
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            foreach (DesktopMaterial item in Enum.GetValues(typeof(DesktopMaterial)))
            {
                materials.Add(item);
            }
            desktopMaterialComboBox.DataSource = materials;
        }
    }
}
