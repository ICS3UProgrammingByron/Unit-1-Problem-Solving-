/*
 * Created by: Byron
 * Created on: 28-02-2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #9 - AreaPer
 * This program will calculate the area and perimeter when the user clicks on what button is labeled after writing the width and length in the tex boxes
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

namespace PerAreaByron
{
    public partial class frmPerArea : Form
    {
        public frmPerArea()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //close the program
            this.Close();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //declare local variables
            double length,area,  width; 


            //convert to string from each text box to a double
            length = double.Parse(txtLength.Text);

            //convert to string from each text box to a double
            width = double.Parse(txtWidth.Text);

            //calculate the area of a rectangle
            area = length * width;

            //insert the area into their respective labels 
            this.lblAreaAnswer.Text = Convert.ToString(area) + "meters Squared";

            //display the area into their respective labels
            this.lblAreaAnswer.Show();





        }

        private void BtnCalculatePer_Click(object sender, EventArgs e)
        {
            //declare local variables 
            double length, perimeter,width;

            //convert the string from each text box to a double
            length = double.Parse(txtLength.Text);

            //convert the string from each text box to a double
            width = double.Parse(txtWidth.Text);

            //calculate the perimeter 
            perimeter = length * 2 + width * 2;

            //insert the perimeter into their respective labels
            this.lblPerAnswer.Text = Convert.ToString(perimeter) + "meters";

            //display the perimeter into their respective labels 
            this.lblPerAnswer.Show();

        }

        private void FrmPerArea_Load(object sender, EventArgs e)
        {
            //hide the perimeter and area answer labels until the user clicks calculate
            this.lblPerAnswer.Hide();

            this.lblAreaAnswer.Hide();
        }
    }
}
