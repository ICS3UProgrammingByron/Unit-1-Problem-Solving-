using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaCost
{
    public partial class frmPizzaCost : Form
    {
        public frmPizzaCost()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //declare local variables 
            double diameter, cost;

            //convert the string from the text box to a double 
            diameter = double.Parse(txtDiameter.Text);

            //calculate the cost of the pizza
            cost = 0.5 * diameter + 0.99 + 0.75 * 1.13;

            //insert the cost of the pizza in to their respective label
            this.lblAnswer.Text = Convert.ToString(cost) + "$";

            //display the cost of the pizza into its respective label
            this.lblAnswer.Show();

        }

        private void FrmPizzaCost_Load(object sender, EventArgs e)
        {
            //hide the label
            lblAnswer.Hide();
        }

        private void MniExit_Click(object sender, EventArgs e)
        {
            //close the program
            this.Close();
        }
    }
}
