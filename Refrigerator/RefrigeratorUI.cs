using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refrigerator
{
    public partial class RefrigeratorUI : Form
    {
        Refrigerator refrigerator = new Refrigerator();
        public RefrigeratorUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            refrigerator.MaximumWeight(maximumWeightTextBox.Text);
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            
            refrigerator.NumberOfItem(itemsTextBox.Text);

            refrigerator.ItemsWeight(weightTextBox.Text);

            MessageBox.Show("Data Saved");

            currentWeightTextBox.Text = refrigerator.GetCurrentWeight();
            remainingWeightTextBox.Text = refrigerator.GetRemainingWeight();
        }
    }
}
