using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrunamentTrackerUI
{
    /// <summary>
    /// Represent prize creation window
    /// </summary>
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            
        }

        private bool VailidateForm() 
        {
            bool output = false;
            int placeNumber = 0;
            bool placeNumberVaildNumber = int.TryParse(placeNameTextBox.Text, out placeNumber);

            if (placeNumberVaildNumber)
            {
                
            }
            return output; 
        }

    }
}
