using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using System.Windows.Forms;

namespace Hotel_Manager
{
    public partial class FoodMenu : MetroForm
    {

        public FoodMenu()
        {
            InitializeComponent();
        }

        private int lunchQ = 0;

        public int LunchQ
        {
            get { return lunchQ; }
            set { lunchQ = value; }
        }
        private int breakfastQ = 0;

        public int BreakfastQ
        {
            get { return breakfastQ; }
            set { breakfastQ = value; }
        }
        private int dinnerQ = 0;

        public int DinnerQ
        {
            get { return dinnerQ; }
            set { dinnerQ = value; }
        }

        private string cleaning= "";

        public string Cleaning
        {
            get { return cleaning; }
            set { cleaning = value; }
        }
        private string towel = "";

        public string Towel
        {
            get { return towel; }
            set { towel = value; }
        }
  
        private string surprise = "";

        public string Surprise
        {
            get { return surprise; }
            set { surprise = value; }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (breakfastCheckBox.Checked)
            {
                
            }
            if (lunchCheckBox.Checked)
            {
                
            }
            if (dinnerCheckBox.Checked)
            {
             
            }
            if (cleaningCheckBox.Checked)
            {
                Cleaning = cleaningCheckBox.Text;
            } if (towelsCheckBox.Checked)
            {
                Towel = towelsCheckBox.Text;
            } 
            if (surpriseCheckBox.Checked)
            {
                Surprise = surpriseCheckBox.Text;
            }
            
            this.Hide();
        }

        private void breakfastCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (breakfastCheckBox.Checked)
            {
   
            }
        }

        private void lunchCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (lunchCheckBox.Checked)
            {
  
            }
        }

        private void dinnerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (dinnerCheckBox.Checked)
            {
  
            }
        }    
    }
}
