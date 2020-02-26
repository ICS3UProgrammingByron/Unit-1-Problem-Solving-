/*
 * Created by: Byron Edmonds-Decosse
 * Created on: 26-02-2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #9 - Circumference
 * This program will calculatet the circumference of a circle when the user enters the radius in the textbox and clicks the calculate button
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircumferenceByron
{
    public partial class frmCircumference : Form
    {
        public frmCircumference()
        {
            InitializeComponent();
        }

        private void FrmCircumference_Load(object sender, EventArgs e)
        {
            lblAnswer.Hide();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //declare local variables
            double radius, circumference;

            // get the radius from the textbox
            radius = double.Parse(txtRadius.Text);

            //calculate the circumference
            circumference = 2 * Math.PI * radius;

            //insert the circumference into their respective labels
            this.lblAnswer.Text = Convert.ToString(circumference) + "cm";

            //display the circumference label with their respective answer
            this.lblAnswer.Show();
        }

        private void MniExit_Click(object sender, EventArgs e)
        {
            //close the program
            this.Close();
        }
    }
}
